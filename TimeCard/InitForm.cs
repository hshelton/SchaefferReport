﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using Microsoft.Reporting.WinForms;
namespace TimeCard
{
    public partial class InitForm : Form
    {
        //association between employee shift numbers and scheduled start times
        private Dictionary<int, DateTime> ShiftNoToStart = new Dictionary<int, DateTime>();
        private Dictionary<int, DateTime> ShiftNoToEnd = new Dictionary<int, DateTime>();

        public InitForm()
        {
            //Shift 0 is the day shift, the rest of the shifts are on a clock in time basis
            ShiftNoToStart.Add(0, new DateTime(1,1,1,6,50,0));
            ShiftNoToEnd.Add(0, new DateTime(1, 1, 1, 15, 30, 0));

            for (var i = 1; i < 200; i++)
            {
                //shifts other than day shift start and end at midnight
                ShiftNoToStart.Add(i, new DateTime(1, 1, 1));
                ShiftNoToEnd.Add(i, new DateTime(1, 1, 1));
            }

            InitializeComponent();
        }

        private void GenerateReport(TimeCardDataSet1.EmployeesRow employee)
        {
            //get the week range data to add to the employee object
            WeekRangeData weeksForPeriod = new WeekRangeData();

            //get the shift start time based off their employee number
            DateTime shiftStart = ShiftNoToStart[employee.Shift];

            // used to calculate overtime
            var isCalifornia = employee.address.Contains(", CA");

            // create object for employee detail
            var emps = new List<EmployeeDetails>();
            var emp = new EmployeeDetails
            {
                EmployeeID = employee.EmployeeID,
                EmpName = employee.EmpName,
                StartDate = DateTime.Now.ToShortDateString(),
                EndDate = DateTime.Now.AddDays(7).ToShortDateString(),
                PeriodEnd = weeksForPeriod.week1.ToShortDateString(),
                PeriodStart = weeksForPeriod.week2.ToShortDateString()
            };
            emps.Add(emp);

            // get the transactions for the report
            var adpt = new TimeCardDataSet1TableAdapters.FlexibleTransactionComTableAdapter();
            adpt.FillByEnrollNo(this.timeCardDataSet1.FlexibleTransactionCom, employee.EmployeeID);

            var transAdpt = new TimeCardDataSet1TableAdapters.TransactionsTableAdapter();
            transAdpt.FillByEnrollNo(this.timeCardDataSet1.Transactions, employee.EmployeeID);

            // build the object
            var report = new List<Joshua>();
            foreach (var trans in this.timeCardDataSet1.FlexibleTransactionCom)
            {
                if (!trans.IsLOWNull())
                {
                    Joshua toAdd = new Joshua
                    {
                        Date = trans.LogDate,
                        InTime = trans.IsLogInNull() ? "" : trans.LogIn.ToString("hh:mm tt"),
                        OutTime = trans.IsLogOutNull() ? "" : trans.LogOut.ToString("hh:mm tt"),
                        ActualTime = "",
                        OT = 0,
                        D = 0,
                        PayTime = "",
                        // ScheduledTime = trans.IsLogInNull() ? "" : shiftStart.ToString("hh:mm tt"),
                        Comments = "",
                        isUtah = !isCalifornia,
                        EmployeeID = emp.EmployeeID,
                        EmpName = emp.EmpName
                    };

                    try
                    {
                        // get the comment
                        var comment = (from t in this.timeCardDataSet1.Transactions where t.LogDate == trans.LogDate && !t.IsfldRemarksNull() select t);
                        if (comment.Count() > 0)
                        {
                            toAdd.Comments = comment.First().fldRemarks;
                        }
                    }
                    catch { }

                    //these variable will hold a date times for employees paid start and end times
                    DateTime LOWStart = new DateTime();
                    DateTime LOWEnd = new DateTime();

                    //make adjustments to the Joshua's log in time to calculate the pay time
                    if (!trans.IsLogInNull())
                    {
                        var compareTime = new DateTime(1, 1, 1, trans.LogIn.Hour, trans.LogIn.Minute, 0);
                        //if the employee arrived before their scheduled start time
                        if (shiftStart > compareTime)
                        {
                            toAdd.PayTime += shiftStart.ToString("hh:mm tt");
                            LOWStart = shiftStart;
                        }
                        else // then they are payed from the closest 15 minute interval after they arrived
                        {
                            var roundedStart = roundToNearest15(trans.LogIn);
                            var payStart = roundedStart.ToString("hh:mm tt");
                            toAdd.PayTime += payStart;
                            LOWStart = roundedStart;
                        }
                    }

                    //make adjustments to the Joshua's log out time to calculate the pay time
                    if (!trans.IsLogOutNull())
                    {
                        var roundedEnd = roundToNearest15(trans.LogOut);
                        toAdd.PayTime += "\n" + roundedEnd.ToString("hh:mm tt");
                        LOWEnd = roundedEnd;
                    }

                    //day shift employees
                    if (employee.Shift == 0)
                    {
                        toAdd.ScheduledTime = ShiftNoToStart[0].ToString("hh:mm tt");
                        toAdd.ScheduledTime += "\n" + ShiftNoToEnd[0].ToString("hh:mm tt");
                    }
                    else
                    {
                        toAdd.ScheduledTime = toAdd.PayTime;
                    }
                    TimeSpan LOWSpan = (LOWEnd - LOWStart);
                    double LOWPaid = Math.Round(LOWSpan.Hours + (double)LOWSpan.Minutes / 60, 2);
                    toAdd.LOW = LOWPaid;
                    report.Add(toAdd);
                }
            }

            // check for an empty employee
            if (report.Count <= 0)
            {
                report.Add(new Joshua
                    {
                        Date = DateTime.Now,
                        EmployeeID = emp.EmployeeID,
                        EmpName = emp.EmpName
                    });
            }

            // handle over time depending on california employees
            var dates = (from r in report select r.Date).Distinct();
            //var firstWeek = report.Min(m => m.Week);

            if (isCalifornia)
            {
                foreach (var date in dates)
                {
                    // get the items for that day
                    var items = (from r in report where r.Date == date select r).ToList();
                    var total = items.Sum(m => m.LOW);
                    if (total > 8) { items.Last().OT = total - 8; }
                }
            }
            else
            {
                var weeks = (from r in report select r.Week).Distinct();

                foreach (var week in weeks)
                {
                    var items = (from r in report where r.Week == week select r).ToList();
                    double amt = 0;
                    foreach (var item in items)
                    {
                        amt = amt + item.LOW;
                        if (amt > 40)
                        {
                            item.OT = amt - 40;
                            amt = 40;
                        }
                    }
                }
            }

            this.reportViewer1.LocalReport.DataSources.Clear();

            // add transactions to the report
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("TransactionSet", report));

            // add the employee detail to the report
            this.reportViewer1.LocalReport.DataSources.Add(
            new Microsoft.Reporting.WinForms.ReportDataSource("EmployeeSet", (object)emps));

            //add the week range detail to the report
            //TODO: Need to figure out how to bind this additional data source to the report
            var weekData = new List<WeekRangeData>();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("WeekSet", (object) weekData));

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
            reportViewer1.SetPageSettings(ps);

            // refresh the report
            this.reportViewer1.RefreshReport();
        }

        private void GenerateAllReport()
        {
            // get the selected employee
            var employees = (from ep in this.timeCardDataSet1.Employees
                             select ep).ToList();

            var emps = new List<EmployeeDetails>();
            var report = new List<Joshua>();
            var adpt = new TimeCardDataSet1TableAdapters.FlexibleTransactionComTableAdapter();
            var transAdpt = new TimeCardDataSet1TableAdapters.TransactionsTableAdapter();

            foreach (var employee in employees)
            {
                var employeeReport = new List<Joshua>();

                //get the week range data to add to the employee object
                WeekRangeData weeksForPeriod = new WeekRangeData();

                //get the shift start time based off their employee number
                DateTime shiftStart = ShiftNoToStart[employee.Shift];

                // used to calculate overtime
                var isCalifornia = employee.address.Contains(", CA");

                // create object for employee detail
                var emp = new EmployeeDetails
                {
                    EmployeeID = employee.EmployeeID,
                    EmpName = employee.EmpName,
                    StartDate = DateTime.Now.ToShortDateString(),
                    EndDate = DateTime.Now.AddDays(7).ToShortDateString(),
                    PeriodEnd = weeksForPeriod.week1.ToShortDateString(),
                    PeriodStart = weeksForPeriod.week2.ToShortDateString()
                };
                emps.Add(emp);

                // get the transactions for the report
                adpt.FillByEnrollNo(this.timeCardDataSet1.FlexibleTransactionCom, employee.EmployeeID);

                transAdpt.FillByEnrollNo(this.timeCardDataSet1.Transactions, employee.EmployeeID);

                bool found = false;

                // build the object
                foreach (var trans in this.timeCardDataSet1.FlexibleTransactionCom)
                {
                    //this.timeCardDataSet1.Transactions
                    if (!trans.IsLOWNull())
                    {
                        found = true;
                        Joshua toAdd = new Joshua
                        {
                            Date = trans.LogDate,
                            InTime = trans.IsLogInNull() ? "" : trans.LogIn.ToString("hh:mm tt"),
                            OutTime = trans.IsLogOutNull() ? "" : trans.LogOut.ToString("hh:mm tt"),
                            ActualTime = "",
                            // LOW = trans.IsLOWNull() ? 0 : trans.LOW, Hayden: the LOW they are interested in is length of paid time
                            OT = 0,
                            D = 0,
                            PayTime = "",
                            // ScheduledTime = trans.IsLogInNull() ? "" : shiftStart.ToString("hh:mm tt"),
                            Comments = "",
                            isUtah = !isCalifornia,
                            EmployeeID = emp.EmployeeID,
                            EmpName = emp.EmpName
                        };

                        try
                        {
                            // get the comment
                            var comment = (from t in this.timeCardDataSet1.Transactions where t.LogDate == trans.LogDate && !t.IsfldRemarksNull() select t);
                            if (comment.Count() > 0)
                            {
                                toAdd.Comments = comment.First().fldRemarks;
                            }
                        }
                        catch { }

                        //these variable will hold a date times for employees paid start and end times
                        DateTime LOWStart = new DateTime();
                        DateTime LOWEnd = new DateTime();

                        //make adjustments to the Joshua's log in time to calculate the pay time
                        if (!trans.IsLogInNull())
                        {
                            var compareTime = new DateTime(1, 1, 1, trans.LogIn.Hour, trans.LogIn.Minute, 0);
                            //if the employee arrived before their scheduled start time
                            if (shiftStart > compareTime)
                            {
                                toAdd.PayTime += shiftStart.ToString("hh:mm tt");
                                LOWStart = shiftStart;
                            }
                            else // then they are payed from the closest 15 minute interval after they arrived
                            {
                                var roundedStart = roundToNearest15(trans.LogIn);
                                var payStart = roundedStart.ToString("hh:mm tt");
                                toAdd.PayTime += payStart;
                                LOWStart = roundedStart;
                            }
                        }

                        //make adjustments to the Joshua's log out time to calculate the pay time
                        if (!trans.IsLogOutNull())
                        {
                            var roundedEnd = roundToNearest15(trans.LogOut);
                            toAdd.PayTime += "\n" + roundedEnd.ToString("hh:mm tt");
                            LOWEnd = roundedEnd;
                        }

                        //day shift employees
                        if (employee.Shift == 0)
                        {
                            toAdd.ScheduledTime = ShiftNoToStart[0].ToString("hh:mm tt");
                            toAdd.ScheduledTime += "\n" + ShiftNoToEnd[0].ToString("hh:mm tt");
                        }
                        else
                        {
                            toAdd.ScheduledTime = toAdd.PayTime;
                        }
                        TimeSpan LOWSpan = (LOWEnd - LOWStart);
                        double LOWPaid = Math.Round(LOWSpan.Hours + (double)LOWSpan.Minutes / 60, 2);
                        toAdd.LOW = LOWPaid;
                        employeeReport.Add(toAdd);
                    }
                }

                // check for an empty employee
                if (!found)
                {
                    report.Add(new Joshua
                    {
                        Date = DateTime.Now,
                        EmployeeID = emp.EmployeeID,
                        EmpName = emp.EmpName
                    });
                }

                // handle over time depending on california employees
                var dates = (from r in employeeReport select r.Date).Distinct();
                //var firstWeek = report.Min(m => m.Week);

                if (isCalifornia)
                {
                    foreach (var date in dates)
                    {
                        // get the items for that day
                        var items = (from r in employeeReport where r.Date == date select r).ToList();
                        var total = items.Sum(m => m.LOW);
                        if (total > 8) { items.Last().OT = total - 8; }
                    }
                }
                else
                {
                    var weeks = (from r in employeeReport select r.Week).Distinct();

                    foreach (var week in weeks)
                    {
                        var items = (from r in employeeReport where r.Week == week select r).ToList();
                        double amt = 0;
                        foreach (var item in items)
                        {
                            amt = amt + item.LOW;
                            if (amt > 40)
                            {
                                item.OT = amt - 40;
                                amt = 40;
                            }
                        }
                    }
                }

                report.AddRange(employeeReport);
            }

            this.reportViewer1.LocalReport.DataSources.Clear();

            // add transactions to the report
            this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("TransactionSet", report));

            // add the employee detail to the report
            this.reportViewer1.LocalReport.DataSources.Add(
            new Microsoft.Reporting.WinForms.ReportDataSource("EmployeeSet", (object)emps));

            //add the week range detail to the report
            //TODO: Need to figure out how to bind this additional data source to the report
            var weekData = new List<WeekRangeData>();
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("WeekSet", (object)weekData));

            System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
            ps.Landscape = true;
            ps.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1170);
            ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.A4;
            reportViewer1.SetPageSettings(ps);

            // refresh the report
            this.reportViewer1.RefreshReport();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeCardDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.timeCardDataSet1.Employees);
            //this.reportViewer1.RefreshReport();
            this.button4_Click(this, new EventArgs());
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (comboBox1 != null && comboBox1.SelectedItem != null)
            {
                // get the selected employee
                var employee = (from ep in this.timeCardDataSet1.Employees
                                where ep.EmployeeID == comboBox1.SelectedValue.ToString()
                                select ep).First();
                GenerateReport(employee);
            }
        }


        /// <summary>
        /// Returns a datetime object with the minutes rounded to the closest 15 minute interval
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DateTime roundToNearest15 (DateTime dt)
        {
            DateTime temp = new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, 0, 0);

            if (dt.Minute <= 15)
            {
                if (dt.Minute >= 8)
                {
                    temp = temp.AddMinutes(15);
                }
            }
            else
            {
                int mult = dt.Minute / 15; 
                if (dt.Minute % 15 >= 8)
                    temp = temp.AddMinutes((mult + 1) * 15);
                else
                {
                    int what = mult * 15;
                    temp = temp.AddMinutes(mult * 15);
                }
            }
         
            return temp;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reportViewer1.PrintDialog();
        }

        private void saveSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.RenderingExtension[] extensions = this.reportViewer1.LocalReport.ListRenderingExtensions();
            var excel = extensions[1];
            this.reportViewer1.ExportDialog(excel);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = comboBox1.SelectedIndex + 1;
                textBox1.Text = "";
                button4_Click(this, new EventArgs());
            }
            catch { }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = comboBox1.SelectedIndex - 1;
                textBox1.Text = "";
                button4_Click(this, new EventArgs());
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateAllReport();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                if (comboBox1 != null && comboBox1.SelectedItem != null)
                {
                    // get the selected employee
                    var employee = (from ep in this.timeCardDataSet1.Employees
                                    where ep.EmployeeID == comboBox1.SelectedValue.ToString()
                                    select ep).First();
                    GenerateReport(employee);
                }
            }
            else
            {
                var text = textBox1.Text.ToLower();

                // get the selected employee
                var employee = (from ep in this.timeCardDataSet1.Employees
                                where ep.EmpName.ToLower().Contains(text)
                                select ep);

                if (employee.Count() > 0)
                {
                    GenerateReport(employee.First());
                }
            }
        }
    }
}

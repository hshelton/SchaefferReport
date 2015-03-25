using System;
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
        

        public InitForm()
        {
            ShiftNoToStart.Add(0, new DateTime(1,1,1, 6, 50, 0));
            ShiftNoToStart.Add(1, new DateTime(1,1,1, 6, 50, 0));
            ShiftNoToStart.Add(2, new DateTime(1,1,1, 6, 50, 0));
            ShiftNoToStart.Add(3, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(4, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(5, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(6, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(7, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(8, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(9, new DateTime(1, 1, 1, 6, 50, 0));
            ShiftNoToStart.Add(10, new DateTime(1, 1, 1, 6, 50, 0));
            InitializeComponent();
        }

        /// <summary>
        /// Set global variable employeeName to hold the selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void GenerateReport()
        {
            if (comboBox1 != null && comboBox1.SelectedItem != null)
            {
                // get the selected employee
                var employee = (from ep in this.timeCardDataSet1.Employees
                                where ep.EmployeeID == comboBox1.SelectedValue.ToString()
                                select ep).First();

                //get the shift start time based off their employee number
                DateTime shiftStart = ShiftNoToStart[employee.Shift];

                // used to calculate overtime
                var isCalifornia = employee.address.Contains(", CA");

                // get the transactions for the report
                var adpt = new TimeCardDataSet1TableAdapters.FlexibleTransactionComTableAdapter();
                adpt.FillByEnrollNo(this.timeCardDataSet1.FlexibleTransactionCom, employee.EmployeeID);

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
                            LOW = trans.IsLOWNull() ? 0 : trans.LOW,
                            OT = 0,
                            D = 0,
                            PayTime = "",
                            ScheduledTime = trans.IsLogInNull() ? "" : trans.LogIn.ToString("hh:mm tt"),
                            Comments = "",
                            isUtah = !isCalifornia
                        };

                        //make adjustments to the Joshua's log in time to calculate the pay time
                        if (!trans.IsLogInNull())
                        {
                            var compareTime = new DateTime(1, 1, 1, trans.LogIn.Hour, trans.LogIn.Minute, 0);
                            //if the employee arrived before their scheduled start time
                            if (shiftStart > compareTime)
                            {
                                toAdd.PayTime += shiftStart.ToString("hh:mm tt");
                            }
                            else // then they are payed from the closest 15 minute interval after they arrived
                            {
                                var payStart = roundToNearest15(trans.LogIn).ToString("hh:mm tt");
                                toAdd.PayTime += payStart;
                            }
                        }

                        //make adjustments to the Joshua's log out time to calculate the pay time
                        if (!trans.IsLogOutNull())
                        {
                            var roundedTime = roundToNearest15(trans.LogOut);
                            toAdd.PayTime += "\n" + roundedTime.ToString("hh:mm tt");


                        }

                        report.Add(toAdd);
                    }
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

                // create object for employee detail
                var emps = new List<EmployeeDetails>();
                emps.Add(new EmployeeDetails
                {
                    EmployeeID = employee.EmployeeID,
                    EmpName = employee.EmpName,
                    StartDate = DateTime.Now.ToShortDateString(),
                    EndDate = DateTime.Now.AddDays(7).ToShortDateString()
                });

                // add the employee detail to the report
                this.reportViewer1.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("EmployeeSet", (object)emps));

                //add the week range detail to the report
                //TODO: Figure out how to link this datasource with the report viewer
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
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeCardDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.timeCardDataSet1.Employees);
            //this.reportViewer1.RefreshReport();
            comboBox1_SelectedIndexChanged(this, new EventArgs());
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            GenerateReport();
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
                int mult = dt.Minute / 15; //how many 15 minute intervals to add for the employee
                if (dt.Minute % 15 >= 8)
                    temp = temp.AddMinutes(mult + 1 * 15);
                else
                {
                    int what = mult * 15;
                    temp = temp.AddMinutes(mult * 15);
                }
            }
         
            return temp;
        }

        private void DayReportObjectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

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
            var first = extensions[0];
            this.reportViewer1.ExportDialog(first);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

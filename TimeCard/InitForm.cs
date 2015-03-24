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

namespace TimeCard
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
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
                        report.Add(new Joshua
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
                        });
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
    }
}

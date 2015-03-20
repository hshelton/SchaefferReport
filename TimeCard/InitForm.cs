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
            // get the selected employee
            var employee = (from ep in this.timeCardDataSet1.Employees 
                            where ep.EmployeeID == comboBox1.SelectedValue.ToString() 
                            select ep).First();

            // retrieve the reports for that employee
            var report = new EmployeeReportObject(employee.EmployeeID).GetDayReports();

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

        private void InitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeCardDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.timeCardDataSet1.Employees);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void DayReportObjectBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

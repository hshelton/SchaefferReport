using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TimeCard
{
    
    public partial class TimeDisplayForm : Form
    {
        private EmployeeReportObject ERObject;


        //number of columns in the data grid view
        public int NumColsInGrid { get; set; }

        //set to true once the connection with the device is made
        bool ConnectionMade = false;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Employee">the employee's name or id or something</param>
        public TimeDisplayForm(String[] EmployeeArgs)
        {
            InitializeComponent();
            EmployeeNameLabel.Text = EmployeeArgs[0];
            EnrollLabel.Text = "Enroll Number: " + EmployeeArgs[1];
            //Initialize the employee reporting object with the ID to run queries from
            ERObject = new EmployeeReportObject(EmployeeArgs[1]);
        }

        public TimeDisplayForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

       

            TodaysDateLabel.Text = DateTime.Today.ToShortDateString();
           
            ThreadPool.QueueUserWorkItem(new WaitCallback(pullDataFromDevice));


            this.DayReportObjectBindingSource.DataSource = ERObject.GetDayReports();
            this.reportViewer1.RefreshReport();
        }


        //update the form on a seperate thread
        private void pullDataFromDevice(Object state)
        {

          
        }

       
    }
}

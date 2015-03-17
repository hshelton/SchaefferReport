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
        }

        public TimeDisplayForm()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            NumColsInGrid = dataGridView1.ColumnCount;

            //bind the data grid to the binding source (in our case data pulled from the fingerprint machine)
            dataGridView1.DataSource = bindingSource1;

            // Initialize the columns in the data table
            DataTable table = new DataTable();
            table.Columns.Add("Employee/Name/Title", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Sched Time", typeof(DateTime));
            table.Columns.Add("Act Time", typeof(DateTime));
            table.Columns.Add("Pay Time", typeof(double));
            table.Columns.Add("OT Hours", typeof(double));
            table.Columns.Add("D-Hours", typeof(double));
            table.Columns.Add("Comments", typeof(string));
            bindingSource1.DataSource = table;

            TodaysDateLabel.Text = DateTime.Today.ToShortDateString();
           
            ThreadPool.QueueUserWorkItem(new WaitCallback(pullDataFromDevice));
        }


        //update the form on a seperate thread
        private void pullDataFromDevice(Object state)
        {
            DataTable currentTable = (DataTable)bindingSource1.DataSource;

            currentTable.Rows.Add("data from device",  DateTime.Today, DateTime.Today, DateTime.Today, 3.4, 1.2, 1.3, "comment");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                if (InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        currentTable.Rows.Add("data from device", DateTime.Today, DateTime.Today, DateTime.Today, 3.4, 1.2, 1.4 + i, "comment");
                    }));

           }
            

            }





      
            //make api call to get data from device

        }
    }
}

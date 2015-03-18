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
        public string employeeName { get; set; }
        public string employeeID { get; set; }

        public Dictionary<string, string> NamesToPositions = new Dictionary<string, string>();


        public InitForm()
        {
            InitializeComponent();
            GetDataFromDB();
            ConnectButton.Enabled = false;

        }

        /// <summary>
        /// Get a list of names from the database
        /// </summary>
        private void GetDataFromDB()
        {
            /*List<String> names = new List<String>();
            //database mdb source is specified relative to bin/debug
            //String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Schaeffer Industries.mdb; Jet OLEDB:Database Password=godilove;";

            TimeCardDataSet1 ds = new TimeCardDataSet1();
            TimeCard.TimeCardDataSet1TableAdapters.EmployeesTableAdapter adpt = new TimeCardDataSet1TableAdapters.EmployeesTableAdapter();
            adpt.Fill(ds.Employees);

            foreach (var emp in ds.Employees)
            {
                NamesToPositions.Add(emp.EmpName, emp.EmployeeID);
            }

            

            foreach (string key in NamesToPositions.Keys)
            {
                comboBox1.Items.Add(key);
            }*/

        }

        /// <summary>
        /// Display the report form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            String[] args = new String[5];

            args[0] = employeeName;
            args[1] = employeeID;

            //create a new display form, passing in employeeName and employeeID
            var displayForm = new TimeDisplayForm(args);
            displayForm.Show();
        }

        /// <summary>
        /// Set global variable employeeName to hold the selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeName = comboBox1.SelectedItem.ToString();
            employeeID = comboBox1.SelectedValue.ToString();
            var id = comboBox1.SelectedValue.ToString();
            TimeCardDataSet1TableAdapters.EmployeesTableAdapter adpt = new TimeCardDataSet1TableAdapters.EmployeesTableAdapter();
            var employeeTable = adpt.GetDataByEmployeeID(id);
            var rows = employeeTable[0].GetDailyFilterRows();

            if (employeeTable.Count > 0)
            {
                ConnectButton.Enabled = true;
            }
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeCardDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.timeCardDataSet1.Employees);

        }
    }
}

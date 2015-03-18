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
    public delegate void ConnectionEventHandler(object sender, object [] connSettings);
  

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
            List<String> names = new List<String>();
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Schaeffer Industries.mdb; Jet OLEDB:Database Password=godilove;";
            OleDbConnection dataConn = new OleDbConnection(connectionString);
            dataConn.Open();

            OleDbDataReader reader = null;

            //TODO: do we only want a list of 'active employees'?
            var cmd = new OleDbCommand("select EmpName, EmployeeID from Employees where active = true order by EmpName", dataConn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (!NamesToPositions.Keys.Contains(reader["EmpName"].ToString().Trim()))
                {
                    NamesToPositions.Add(reader["EmpName"].ToString(), reader["EmployeeID"].ToString());

                }

            }

            foreach (string key in NamesToPositions.Keys)
            {
                comboBox1.Items.Add(key);
            }
            dataConn.Close();

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
            employeeID = NamesToPositions[employeeName];

            if (!String.IsNullOrEmpty(employeeName))
            {
                ConnectButton.Enabled = true;
            }
        }
    }
}

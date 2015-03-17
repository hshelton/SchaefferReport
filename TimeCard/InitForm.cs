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

            //TODO: reference real schema
            var cmd = new OleDbCommand("select FirstName, LastName from Employees order by LastName", dataConn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                names.Add(reader["FirstName"].ToString());
                comboBox1.Items.Add(reader["LastName"].ToString() + ", " + reader["FirstName"]);
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
            //past display form useful arguments pulled from the database
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

            if (!String.IsNullOrEmpty(employeeName))
            {
                ConnectButton.Enabled = true;
            }
        }
    }
}

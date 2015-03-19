using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; 

namespace TimeCard
{
    // a day contains all the relevent information for a single day
    public class DayReportObject
    {
        public string Date { get; set; }
        public string Scheduled_Time { get; set; }
        public string Actual_Time { get; set; }
        public string Pay_Time { get; set; }
        public string OT {get; set;}
        public string D { get; set; }
        public string Total_hours { get; set; }
        public string Comments { get; set; }


        /// <summary>
        /// Default constructor. Builds data for a single line of the report
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_scheduledTime"></param>
        public DayReportObject(string _date, string _scheduledTime)
        {
            Date = _date;
            Scheduled_Time = _scheduledTime;
        }

        public DayReportObject()
        {
            
        }


    }

    /// <summary>
    /// Employee Report Objects are basically a list of DayReportObjects. DayReportObjects contain the core data that is displayed
    /// </summary>
    public class EmployeeReportObject
    {
        private List<DayReportObject> e_days;


        public EmployeeReportObject(string employeeID)
        {
            e_days = new List<DayReportObject>();
            generateReport(employeeID);
        }


        /// <summary>
        /// Uses the dbKey to run queries on the database. These queries each create new DayReportObjects, which are then
        /// added to e_days
        /// </summary>
        /// <param name="dbKey">employeeID </param>
        public void generateReport(string dbKey)
        {

            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Schaeffer Industries.mdb; Jet OLEDB:Database Password=godilove;";

            OleDbConnection dataConn = new OleDbConnection(connectionString);
            dataConn.Open();

            OleDbDataReader reader = null;



            //get week one and week two in order to grab transactions for those time periods
            var getWeeks = new OleDbCommand("select DISTINCT Week from WeeklyTotal", dataConn);
            reader = getWeeks.ExecuteReader();
            reader.Read();
            DateTime week1End = (DateTime)reader["Week"];
            reader.Read();
            DateTime week2End = (DateTime) reader["Week"];

            //from 1 week prior to 1st week - subtract one week from End of 1st week 
            DateTime Week1StartTime = week1End.Subtract(new TimeSpan(7, 0, 0, 0, 0));

       
            //get entries in transactions table for individual days of first week
            TimeCardDataSet1TableAdapters.TransactionsTableAdapter TransactionAdapter = new TimeCardDataSet1TableAdapters.TransactionsTableAdapter();
            var transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(dbKey, Week1StartTime, week1End);

            DayReportObject currentObject = new DayReportObject { Actual_Time = "" };
            DateTime currentDay = transactionTable1[0].LogDate;

            for(int i = 0; i < transactionTable1.Count; i++)
            {
                var dailyTime = transactionTable1[i].LogTime;
                currentObject.Actual_Time = currentObject.Actual_Time + dailyTime + " ";
                var currentDate = transactionTable1[i].LogTime;

                if(currentDay != currentDate) //then we're done collecting this day's data
                {
                    e_days.Add(currentObject);
                    currentObject = new DayReportObject {Actual_Time = " "};
                    currentDay = currentDate;
                }
            }


                for (int i = 0; i < transactionTable1.Count; i++)
                {
                   var dailyTime = transactionTable1[i].LogTime;
                   
                   string transactionType = transactionTable1[i].InOutMode;
                   //append the time
                   currentObject.Actual_Time = currentObject.Actual_Time + dailyTime + " ";
                   
                    //if its the next day then add current
                   if (currentDay!= 
                   {
                       e_days.Add(current);
                       current = new DayReportObject { Actual_Time = "" };
                   }
                }
            

       
   
            var cmd = new OleDbCommand("select wLOW, WOT, Week from WeeklyTotal where wEmployeeID like " + dbKey, dataConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var wLow = reader["wLOW"].ToString();
                var WOT = reader["WOT"].ToString();
                DateTime Week =(DateTime) reader["Week"];
                //format week nicely.
                string WeekTrimmed = Week.ToString().Substring(0, Week.ToString().IndexOf(' '));
                e_days.Add(new DayReportObject { Date = "Pay Week Ending: " + WeekTrimmed, OT = WOT, Total_hours = wLow});
            }

            dataConn.Close();
        }

        public List<DayReportObject> GetDayReports()
        {

            return e_days;

        }

    }










}

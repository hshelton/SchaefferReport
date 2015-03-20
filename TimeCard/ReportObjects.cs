using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using TimeCard.TimeCardDataSet1TableAdapters;

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

    public class EmployeeDetails
    {
        public string EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
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
        /// added to e_days. edays are the objects used to generate the report
        /// </summary>
        /// <param name="dbKey">employeeID </param>
        public void generateReport(string dbKey)
        {

            TimeCardDataSet1TableAdapters.EmployeesTableAdapter adpt = new TimeCardDataSet1TableAdapters.EmployeesTableAdapter();
            var employeeTable = adpt.GetDataByEmployeeID(dbKey);

            //get week one and week two in order to grab transactions for those time periods

            TimeCardDataSet1TableAdapters.WeeklyTotalTableAdapter weeklyAdapter = new TimeCardDataSet1TableAdapters.WeeklyTotalTableAdapter();
            var weeklyTable = weeklyAdapter.GetDistinctWeeks();
            DateTime week1End = weeklyTable[0].Week;
            DateTime week2End = weeklyTable[1].Week;

            //from 1 week prior to 1st week - subtract one week from End of 1st week 
            DateTime Week1StartTime = week1End.Subtract(new TimeSpan(7, 0, 0, 0, 0));

            //get entries in transactions table for individual days of first week
            TimeCardDataSet1TableAdapters.TransactionsTableAdapter TransactionAdapter = new TimeCardDataSet1TableAdapters.TransactionsTableAdapter();
            var transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(dbKey, Week1StartTime, week1End);

            DayReportObject currentObject = new DayReportObject { Actual_Time = "" };
 

            DateTime CurrentObjectDate;
            try
            {
                CurrentObjectDate = transactionTable1[0].LogDate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            //iterate through the transaction table results
            for (int i = 0; i < transactionTable1.Count; i++)
            {
                DateTime rowDate = transactionTable1[i].LogDate;
            
                if (rowDate.CompareTo(CurrentObjectDate) != 0) //if it's a new day it should go on the next DayReportObject
                {
                    currentObject.Date = CurrentObjectDate.ToShortDateString();
                    e_days.Add(currentObject);

                    currentObject = new DayReportObject { Actual_Time = transactionTable1[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable1[i].LogDate; //the new currentobject date is the newest date encountered
                 
                }
                else //add it to the same DayReportObject
                {
                    currentObject.Actual_Time = currentObject.Actual_Time + transactionTable1[i].LogTime.ToShortTimeString() + "\n";
         
                }
            }

          //  currentObject.Date = lastDateHolder.Date.ToString().Substring(0, lastDateHolder.Date.ToString().IndexOf(' '));
            e_days.Add(currentObject); //Add that last day object

           TimeCardDataSet1.WeeklyTotalDataTable weekTB = weeklyAdapter.GetDataByEmployeeID(dbKey);

            //display weekly totals for first week
            AddWeekAsEntry(weekTB, 0);

            //TODO: figure out why friday1 & monday2 have wrong date displayed

            /* BUILD SECOND WEEK **********************************************************/

            DayReportObject currentObject2 = new DayReportObject { Actual_Time = "" };

            try
            {
                CurrentObjectDate = transactionTable1[1].LogDate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(dbKey, week1End, week2End);
            //iterate through the transaction table results
            for (int i = 0; i < transactionTable1.Count; i++)
            {
                DateTime rowDate = transactionTable1[i].LogDate;
                if (rowDate.CompareTo(CurrentObjectDate) != 0) //if it's a new day it should go on the next DayReportObject
                {
                    currentObject.Date = CurrentObjectDate.ToShortDateString();
                    e_days.Add(currentObject);

                    currentObject = new DayReportObject { Actual_Time = transactionTable1[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable1[i].LogDate; //the new currentobject date is the newest date encountered
                }
                else //add it to the same DayReportObject
                {
                    currentObject.Actual_Time = currentObject.Actual_Time + transactionTable1[i].LogTime.ToShortTimeString() + "\n";
                }
            }

            currentObject.Date = transactionTable1[transactionTable1.Count - 1].LogDate.ToShortDateString();
            e_days.Add(currentObject); //Add that last day object


            //display weekly totals for first week
            AddWeekAsEntry(weekTB, 1);



    
        }


        private void AddWeekAsEntry(TimeCardDataSet1.WeeklyTotalDataTable tbl, int weekNo)
        {
            var wLow = tbl[weekNo].wLOW;
            var WOT = tbl[weekNo].wOT;
            DateTime week = tbl[weekNo].Week;
            //format week nicely.
            string WeekTrimmed = week.ToString().Substring(0, week.ToString().IndexOf(' '));
            e_days.Add(new DayReportObject { Date = "Pay Week Ending: " + WeekTrimmed, OT = WOT, Total_hours = wLow });


        }

        public List<DayReportObject> GetDayReports()
        {

            return e_days;

        }

    }










}

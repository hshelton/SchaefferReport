using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using TimeCard.TimeCardDataSet1TableAdapters;
using System.Globalization;
using System.Data;

namespace TimeCard
{


    public class Joshua
    {
        // employee information
        public string EmployeeID { get; set; }
        public string EmpName { get; set; }

        // transaction information
        public DateTime Date { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string ScheduledTime { get; set; }
        public string ActualTime { get; set; }
        public string PayTime { get; set; }
        public double LOW { get; set; }
        public double OT { get; set; }
        public double D { get; set; }
        public string Comments { get; set; }
        public bool isUtah { get; set; }

        public int Week
        {
            get
            {
                CultureInfo ciGetNumber = CultureInfo.CurrentCulture;
                return ciGetNumber.Calendar.GetWeekOfYear(Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            }
        }

        public double TWH
        {
            get
            {
                return LOW + D;
            }
        }
    }

    public class EmployeeDetails
    {
        public string EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Test { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }

    }

    public class WeekRangeData
    {
        WeeklyTotalTableAdapter adpt = new TimeCardDataSet1TableAdapters.WeeklyTotalTableAdapter();
        public DateTime week1;
        public DateTime week2;
        public WeekRangeData()
        {
            var weeks = adpt.GetDistinctWeeks();
            try
            {
                week2 = weeks[0].Week.Date.AddDays(-6);
                week1 = weeks[1].Week;
            }
            catch { }
        }
    }
    /// <summary>
    /// Employee Report Objects are basically a list of Joshuas. Joshuas contain the core data that is displayed
    /// </summary>
    public class EmployeeReportObject
    {
        private List<Joshua> e_days;
        private TimeCardDataSet1.EmployeesRow _employee;


        public EmployeeReportObject(TimeCardDataSet1.EmployeesRow employee)
        {
            e_days = new List<Joshua>();
            _employee = employee;
            generateReport(employee);
        }

        /// <summary>
        /// Uses the dbKey to run queries on the database. These queries each create new Joshuas, which are then
        /// added to e_days. edays are the objects used to generate the report
        /// </summary>
        /// <param name="dbKey">employeeID </param>
        public void generateReport(TimeCardDataSet1.EmployeesRow employee)
        {

            //get week one and week two in order to grab transactions for those time periods

            TimeCardDataSet1TableAdapters.WeeklyTotalTableAdapter weeklyAdapter = new TimeCardDataSet1TableAdapters.WeeklyTotalTableAdapter();
            var weeklyTable = weeklyAdapter.GetDistinctWeeks();
            DateTime week1End = weeklyTable[0].Week;
            DateTime week2End = weeklyTable[1].Week;

            //from 1 week prior to 1st week - subtract one week from End of 1st week 
            DateTime Week1StartTime = week1End.Subtract(new TimeSpan(7, 0, 0, 0, 0));

            //get entries in transactions table for individual days of first week
            TimeCardDataSet1TableAdapters.TransactionsTableAdapter TransactionAdapter = new TimeCardDataSet1TableAdapters.TransactionsTableAdapter();
            var transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(employee.EmployeeID, Week1StartTime, week1End);

            Joshua currentObject = new Joshua { ActualTime = "" };
 

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
            
                if (rowDate.CompareTo(CurrentObjectDate) != 0) //if it's a new day it should go on the next Joshua
                {
                    currentObject.Date = CurrentObjectDate;
                    e_days.Add(currentObject);

                    currentObject = new Joshua { ActualTime = transactionTable1[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable1[i].LogDate; //the new currentobject date is the newest date encountered
                 
                }
                else //add it to the same Joshua
                {
                    currentObject.ActualTime = currentObject.ActualTime + transactionTable1[i].LogTime.ToShortTimeString() + "\n";
         
                }
            }

          //  currentObject.Date = lastDateHolder.Date.ToString().Substring(0, lastDateHolder.Date.ToString().IndexOf(' '));
            e_days.Add(currentObject); //Add that last day object

           TimeCardDataSet1.WeeklyTotalDataTable weekTB = weeklyAdapter.GetDataByEmployeeID(employee.EmployeeID);

            //display weekly totals for first week
            AddWeekAsEntry(weekTB, 0);

            //TODO: figure out why friday1 & monday2 have wrong date displayed

            /* BUILD SECOND WEEK **********************************************************/

            Joshua currentObject2 = new Joshua { ActualTime = "" };

            try
            {
                CurrentObjectDate = transactionTable1[1].LogDate;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(employee.EmployeeID, week1End, week2End);
            //iterate through the transaction table results
            for (int i = 0; i < transactionTable1.Count; i++)
            {
                DateTime rowDate = transactionTable1[i].LogDate;
                if (rowDate.CompareTo(CurrentObjectDate) != 0) //if it's a new day it should go on the next Joshua
                {
                    currentObject.Date = CurrentObjectDate;
                    e_days.Add(currentObject);

                    currentObject = new Joshua { ActualTime = transactionTable1[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable1[i].LogDate; //the new currentobject date is the newest date encountered
                }
                else //add it to the same Joshua
                {
                    currentObject.ActualTime = currentObject.ActualTime + transactionTable1[i].LogTime.ToShortTimeString() + "\n";
                }
            }

            currentObject.Date = transactionTable1[transactionTable1.Count - 1].LogDate;
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
            //e_days.Add(new Joshua { Date = "Pay Week Ending: " + WeekTrimmed, OT = WOT, TotalHours = wLow });

        }

        public List<Joshua> GetDayReports()
        {
            return e_days;
        }

    }










}

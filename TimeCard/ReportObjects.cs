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
        public string Total_hours{ get; set; }
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

        /*************************************
       //IMPORTANT - this method throws exceptions for certain employees - like it works fine for Demetrius Green, but fails on some others
         * I think the ones that it fails on are those who haven't worked in that time period
        /**********************************/
        public void generateReport(string dbKey)
        {
            EmployeesTableAdapter adpt = new EmployeesTableAdapter();
            var employeeTable = adpt.GetDataByEmployeeID(dbKey);

            //figure out week ending and starting dates so that we can get data in weekly ranges
            WeeklyTotalTableAdapter weeklyAdapter = new WeeklyTotalTableAdapter();
            var weeklyTable = weeklyAdapter.GetDistinctWeeks();
            DateTime week1End = weeklyTable[0].Week;
            DateTime week2End = weeklyTable[1].Week;
            DateTime Week1StartTime = week1End.Subtract(new TimeSpan(7, 0, 0, 0, 0));

            //get entries in transactions table for individual days of first week (clock in and out data)
            TransactionsTableAdapter TransactionAdapter = new TransactionsTableAdapter();
            var transactionTable1 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(dbKey, Week1StartTime, week1End);
            if (transactionTable1.Count == 0)
                return;

            //the first DayReport item is blank
            DayReportObject currentObject = new DayReportObject { Actual_Time = "" };
            DateTime CurrentObjectDate = transactionTable1[0].LogDate;


            //loop through the results of the daily transactions
            for (int i = 0; i < transactionTable1.Count; i++)
            {
                DateTime rowDate = transactionTable1[i].LogDate;

                //if the date we're looking at is the same as the previous one we considered, then add clock in data to this day
                if (rowDate.CompareTo(CurrentObjectDate) == 0)
                {
                    currentObject.Actual_Time += transactionTable1[i].LogTime.ToShortTimeString() + "\n";
                }
                else //then the date we're looking at is the next day so finish out the current object and add it to e_days
                {

                    string accumTime = GetAccumalatedTimeForDay(dbKey, CurrentObjectDate);
                    currentObject.Total_hours = accumTime;
                    currentObject.Date = CurrentObjectDate.ToShortDateString();
                    e_days.Add(currentObject);
                    //current object is now set up to store information for the next day
                    currentObject = new DayReportObject { Actual_Time = transactionTable1[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable1[i].LogDate;
                }
            }
            //the last currentObject won't have been added yet
            currentObject.Date = CurrentObjectDate.ToShortDateString();
            string accumulatedTime = GetAccumalatedTimeForDay(dbKey, CurrentObjectDate);
            currentObject.Total_hours = accumulatedTime;
            e_days.Add(currentObject);

            TimeCardDataSet1.WeeklyTotalDataTable weekTB = weeklyAdapter.GetDataByEmployeeID(dbKey);
            AddWeekAsEntry(weekTB, 0); //add week ending data 
            e_days.Add(new DayReportObject()); //add spacer 


            //Repeat above process for second week
            var transactionTable2 = TransactionAdapter.GetDataByEnrollNoAndTimeRange(dbKey, week1End, week2End);
            if (transactionTable2.Count == 0)
                return;
            CurrentObjectDate = transactionTable2[0].LogDate;
            currentObject = new DayReportObject { Actual_Time = "" };

            //loop through the results of the daily transactions
            for (int i = 0; i < transactionTable2.Count; i++)
            {
                DateTime rowDate = transactionTable2[i].LogDate;

                //if the date we're looking at is the same as the previous one we considered, then add clock in data to this day
                if (rowDate.CompareTo(CurrentObjectDate) == 0)
                {
                    currentObject.Actual_Time += transactionTable2[i].LogTime.ToShortTimeString() + "\n";
                }
                else //then the date we're looking at is the next day so finish out the current object and add it to e_days
                {

                    string accumTime = GetAccumalatedTimeForDay(dbKey, CurrentObjectDate);
                    currentObject.Total_hours = accumTime;
                    currentObject.Date = CurrentObjectDate.ToShortDateString();
                    e_days.Add(currentObject);
                    //current object is now set up to store information for the next day
                    currentObject = new DayReportObject { Actual_Time = transactionTable2[i].LogTime.ToShortTimeString() + "\n" };
                    CurrentObjectDate = transactionTable2[i].LogDate;
                }
            }
            //the last currentObject won't have been added yet
            currentObject.Date = CurrentObjectDate.ToShortDateString();
            accumulatedTime = GetAccumalatedTimeForDay(dbKey, CurrentObjectDate);
            currentObject.Total_hours = accumulatedTime;
            e_days.Add(currentObject);
            AddWeekAsEntry(weekTB, 1); //add week ending data 


        }


        private string GetAccumalatedTimeForDay(string dbKey, DateTime day)
        {
            //this will be used to get hourly totals for given days - Time ranges of work corresponding to clock ins
            FlexibleTransactionComTableAdapter flexTransAdapter = new FlexibleTransactionComTableAdapter();
            //get length of time worked for this day - I think LOW is the time paid for
            var LOWSTable = flexTransAdapter.GetLOWByEnrollNoAndLogDate(dbKey, day);
            double accumulatedTime = 0;
            //maybe they clocked in & out more than once
            for (int j = 0; j < LOWSTable.Count-1; j++)
            {
                    accumulatedTime += LOWSTable[j].LOW;
            }
            accumulatedTime = Math.Round(accumulatedTime, 2);
            return accumulatedTime.ToString();
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

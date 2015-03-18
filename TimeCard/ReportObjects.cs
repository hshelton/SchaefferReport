using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeCard
{
    // a day contains all the relevent information for a single day
    public class DayReportObject
    {
        public string e_day { get; set; }
        public string e_scheduledTime { get; set; }

        /// <summary>
        /// Default constructor. Builds data for a single line of the report
        /// </summary>
        /// <param name="_date"></param>
        /// <param name="_scheduledTime"></param>
        public DayReportObject(string _date, string _scheduledTime)
        {
            e_day = _date;
            e_scheduledTime = _scheduledTime;
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
            e_days.Add(new DayReportObject("1/1/2015", "2:15 PM"));
            e_days.Add(new DayReportObject("1/2/2015", "2:15 PM"));
            e_days.Add(new DayReportObject("1/3/2015", "2:15 PM"));
            e_days.Add(new DayReportObject("1/4/2015", "2:15 PM"));
        }

        public List<DayReportObject> GetDayReports()
        {

            return e_days;

        }

    }










}

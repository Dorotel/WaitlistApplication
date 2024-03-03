using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitlistApplication.MVVM.ViewModel
{
    internal class MainForm_UserControl_ItemViewModel
    {
        public MainForm_UserControl_ItemViewModel(string workCenter, string requestType, DateTime requestTime, int timeRemaining,
            string mhandler, string request1, string request2, string request3, string request4, string request5)
        {
            var now = DateTime.Now;
            var jobShouldBeDone = requestTime.AddMinutes(timeRemaining);
            var jobTimeSpan = new TimeSpan(0, timeRemaining, 0);
            var timeSpan = jobShouldBeDone - now;
            var timeSpan2 = timeSpan.Minutes;

            var isOverdue = timeSpan2 < 0;

            WorkCenter = workCenter;
            RequestType = requestType;
            TimeRemaining = requestTime.Add(jobTimeSpan).ToString(@"hh\:mm\ tt", CultureInfo.InvariantCulture);
            TimeRemaining = timeSpan2 + " Minutes";
            RequestTime = requestTime.ToString(@"hh\:mm\ tt", CultureInfo.InvariantCulture);
            RequestTime = "Time Entered: " + RequestTime;
            Status = isOverdue ? "Overdue" : "On Time";
            MHandler = mhandler;
            Request1 = request1;
            Request2 = request2;
            Request3 = request3;
            Request4 = request4;
            Request5 = request5;
            IsOverdue = isOverdue;
            TimeRemaining2 = timeSpan2;
        }

        public string WorkCenter { get; set; }
        public string RequestType { get; set; }
        public string RequestTime { get; set; }
        public string TimeRemaining { get; set; }
        public string Status { get; set; }
        public string MHandler { get; set; }
        public string Request1 { get; set; }
        public string Request2 { get; set; }
        public string Request3 { get; set; }
        public string Request4 { get; set; }
        public string Request5 { get; set; }
        public bool IsOverdue { get; set; }
        public int TimeRemaining2 { get; set; }
    }

}

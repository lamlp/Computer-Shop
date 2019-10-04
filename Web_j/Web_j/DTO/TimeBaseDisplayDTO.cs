using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class TimeBaseDisplayDTO
    {
        private int _TimeID;

        public int TimeID
        {
            get { return _TimeID; }
            set { _TimeID = value; }
        }
        private DateTime _FromTime;

        public DateTime FromTime
        {
            get { return _FromTime; }
            set { _FromTime = value; }
        }
        private DateTime _ToTime;

        public DateTime ToTime
        {
            get { return _ToTime; }
            set { _ToTime = value; }
        }
        private DateTime _FromHour;

        public DateTime FromHour
        {
            get { return _FromHour; }
            set { _FromHour = value; }
        }
        private DateTime _ToHour;

        public DateTime ToHour
        {
            get { return _ToHour; }
            set { _ToHour = value; }
        }
        private int _DayOfWeek;

        public int DayOfWeek
        {
            get { return _DayOfWeek; }
            set { _DayOfWeek = value; }
        }
    }
}
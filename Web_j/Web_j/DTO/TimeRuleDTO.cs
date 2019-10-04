using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class TimeRuleDTO
    {
        private int _TimeID;

        public int TimeID
        {
            get { return _TimeID; }
            set { _TimeID = value; }
        }
        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
    }
}
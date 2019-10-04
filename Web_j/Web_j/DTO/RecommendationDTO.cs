using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class RecommendationDTO
    {
        private int _ReProductID;

        public int ReProductID
        {
            get { return _ReProductID; }
            set { _ReProductID = value; }
        }
        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
    }
}
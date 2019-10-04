using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class CategoryMenuDTO
    {
        private int _CategoryID;

        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
        private string _ProductID;

        public string ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
    }
}
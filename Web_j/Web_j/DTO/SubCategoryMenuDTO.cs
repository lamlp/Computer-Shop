using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class SubCategoryMenuDTO
    {
        private int _SubCategoryID;

        public int SubCategoryID
        {
            get { return _SubCategoryID; }
            set { _SubCategoryID = value; }
        }
        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
    }
}
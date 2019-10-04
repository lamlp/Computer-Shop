using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class SubCategoryDTO
    {
        private int _SubCategoryID;

        public int SubCategoryID
        {
            get { return _SubCategoryID; }
            set { _SubCategoryID = value; }
        }
        private string _SubCategoryName;

        public string SubCategoryName
        {
            get { return _SubCategoryName; }
            set { _SubCategoryName = value; }
        }
        private int _CategoryID;

        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
    }
}
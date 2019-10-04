using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class ProductDTO
    {
        private int _ProductID;
        private string _ProductName;
        private string _Image;
        private int _Price;
        private string _Descriptions;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public string Descriptions
        {
            get { return _Descriptions; }
            set { _Descriptions = value; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class MyOrdersDTO
    {
        private string _TaiKhoan;
        private int _OrderID;

        public string TaiKhoan
        {
            get
            {
                return _TaiKhoan;
            }

            set
            {
                _TaiKhoan = value;
            }
        }

        public int OrderID
        {
            get
            {
                return _OrderID;
            }

            set
            {
                _OrderID = value;
            }
        }
    }
}
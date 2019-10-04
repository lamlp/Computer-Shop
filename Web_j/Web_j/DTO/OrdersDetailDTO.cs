using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class OrdersDetailDTO
    {
        private int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        private int _ProductID;

        public int ProductID
        {
            get { return _ProductID; }
            set { _ProductID = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        } 
    }
}
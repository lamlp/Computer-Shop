using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_j
{
    public class CustomerDTO
    {
        private string _TaiKhoan;
        private string _MatKhau;
        private string _TenKH;
        private DateTime _NgaySinh;
        private bool _GioiTinh;
        private string _CMND;
        private string _DiaChi;
        private string _DT;
        private string _Email;
        private bool _LoaiKH;

        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }


        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }


        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }


        public bool GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }


        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }


        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }


        public string DT
        {
            get { return _DT; }
            set { _DT = value; }
        }


        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        public bool LoaiKH
        {
            get { return _LoaiKH; }
            set { _LoaiKH = value; }
        }
    }
}
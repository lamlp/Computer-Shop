using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_j
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void aa()
        {
            btnDangNhap.Enabled = false;
        }
        public void HienThiRong()
        {
            btnDangXuat.Enabled = false;
            btnDangNhap.Enabled = true;
            btnDanhMuc.Enabled = false;
            btnDSDonHang.Enabled = false;
            btnSanPham.Enabled = false;
            btnSPLienQuan.Enabled = false;
            btnTGHienThi.Enabled = false;
            btnTTKhachHang.Enabled = false;
        }
        public void HienThiDangNhap()
        {
            btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            btnDanhMuc.Enabled = true;
            btnDSDonHang.Enabled = true;
            btnSanPham.Enabled = true;
            btnSPLienQuan.Enabled = true;
            btnTGHienThi.Enabled = true;
            btnTTKhachHang.Enabled = true;
        }

        private void timeBaseDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeBaseDisplay timebase = new TimeBaseDisplay();
            timebase.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap(this);
            dangnhap.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap(this);
            dangnhap.btnThoat_Click(sender, e);
            MessageBox.Show("Đăng Xuất Thành Công");
            HienThiRong();
        }

        private void btnTTKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang();
            khachhang.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanpham = new SanPham();
            sanpham.ShowDialog();
        }

        private void btnTGHienThi_Click(object sender, EventArgs e)
        {
            TimeBaseDisplay timebase = new TimeBaseDisplay();
            timebase.ShowDialog();
        }

        private void btnSPLienQuan_Click(object sender, EventArgs e)
        {
            Recommendation recom = new Recommendation();
            recom.ShowDialog();
        }

        private void btnDSDonHang_Click(object sender, EventArgs e)
        {
            DonHang donhang = new DonHang();
            donhang.ShowDialog();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.ShowDialog();
        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            HienThiRong();
        }
    }
}

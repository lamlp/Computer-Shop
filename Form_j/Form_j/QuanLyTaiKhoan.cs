using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;
using Controller;

namespace QuangVinh
{
    public partial class QuanLyTaiKhoan : Form
    {
        
        QuanLyTaiKhoan_CT dstk = new QuanLyTaiKhoan_CT();
        EC_tblDangNhap ec = new EC_tblDangNhap();
        bool themmoi;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            dtDSSP.DataSource = dstk.LoadDSTK("");
            DataGridViewCheckBoxColumn cx = new DataGridViewCheckBoxColumn();
            dtDSSP.Columns[0].HeaderText = "Tài Khoản";
            dtDSSP.Columns[1].HeaderText = "Mật Khẩu";
            dtDSSP.Columns[2].HeaderText = "Tên";
            dtDSSP.Columns[3].HeaderText = "Địa Chỉ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnQuyen.Enabled = false;
            txtTaiKhoan.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.Text = "";
            txtTaiKhoan.Text = "";
            txtTen.Text = "";
            txtMatKhau.Text = "";
            txtTaiKhoan.Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnQuyen.Enabled = false;
            txtTaiKhoan.ReadOnly = true;
            txtTen.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtMatKhau.ReadOnly = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.TaiKhoan = txtTaiKhoan.Text;
                dstk.XoaTK(ec);
                MessageBox.Show("Đã xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không thể xóa");
            }
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin");
                return;
            }
            if (themmoi == true)
            {
                try
                {
                    ec.TaiKhoan = txtTaiKhoan.Text;
                    ec.MatKhau = txtMatKhau.Text;
                    ec.Ten = txtTen.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    ec.QuanLyTaiKhoan = false;
                    ec.QuanLyKhachHang = false;
                    ec.SanXuat = false;
                    ec.ThuKhoTP = false;
                    ec.ThuKhoNVL = false;
                    dstk.ThemTK(ec);
                    MessageBox.Show("Thêm mới thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                try
                {
                    ec.TaiKhoan = txtTaiKhoan.Text;
                    ec.MatKhau = txtMatKhau.Text;
                    ec.Ten = txtTen.Text;
                    ec.DiaChi = txtDiaChi.Text;
                    dstk.SuaTK(ec);
                    MessageBox.Show("Sửa thành công");
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            txtTen.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            btnQuyen.Enabled = true;
            HienThi();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            HienThi();
            txtDiaChi.ReadOnly = true;
            txtTaiKhoan.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtMatKhau.ReadOnly = true;
            
        }

        private void dtDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTaiKhoan.Text = dtDSSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = dtDSSP.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTen.Text = dtDSSP.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDiaChi.Text = dtDSSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnQuyen_Click(object sender, EventArgs e)
        {
            PhanQuyen phanquyen = new PhanQuyen();
            phanquyen.ShowDialog();
            btnLoad_Click(sender,e);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dtDSSP.DataSource = dstk.LoadDSTK("");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtDSSP.DataSource = dstk.LoadDSTK("");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tim = txtTim.Text;
            if (cbxLoai.Text == "Tài Khoản")
            {
                dtDSSP.DataSource = dstk.LoadDSTK(" where TaiKhoan =N'" + tim + "'");
            }
            else if (cbxLoai.Text == "Tên")
            {
                dtDSSP.DataSource = dstk.LoadDSTK(" where Ten =N'" + tim + "'");
            }
            else MessageBox.Show("Xin hãy chọn phương thức tìm kiếm");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_j
{
    public partial class DangNhap : Form
    {
        public Main mainForm;
        WS.WScode sv = new WS.WScode();
        DataTable dt;
        public DangNhap(Main fm)
        {
            InitializeComponent();
            mainForm = fm;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            try
            {
                if (TaiKhoan == "")
                {
                    MessageBox.Show("Vui lòng điền tài khoản!", "Thông Báo");
                    txtTaiKhoan.Select();
                    return;
                }
                if (MatKhau == "")
                {
                    MessageBox.Show("Vui lòng điền mật khẩu!", "Thông Báo");
                    txtMatKhau.Select();
                    return;
                }
                dt = sv.DangNhapAdmin(TaiKhoan,MatKhau).Tables[0];

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    mainForm.HienThiDangNhap();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!");
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    txtTaiKhoan.Focus();
                }
            }
            catch
            { }
        }

        public void btnThoat_Click(object sender, EventArgs e)
        {
            mainForm.HienThiRong();
            this.Close();
        }
    }
}

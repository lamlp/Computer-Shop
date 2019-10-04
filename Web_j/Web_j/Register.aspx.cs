using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class Register : System.Web.UI.Page
    {
        WS.WScode sv = new WS.WScode();
        WS.CustomerDTO cus = new WS.CustomerDTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                cus.TaiKhoan = txtTaiKhoan.Text;
                if (sv.CheckKH(cus) > 0)
                { Response.Write("<script>alert('Tài khoản đã tồn tài'); window.location='Register.aspx'</script>"); }
                else
                {
                    cus.MatKhau = txtMatKhau.Text;
                    cus.TenKH = txtTenKH.Text;
                    cus.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                    if (rdNam.Checked == true)
                        cus.GioiTinh = true;
                    else if (rdNu.Checked == true) cus.GioiTinh = false;
                    cus.CMND = txtCMND.Text;
                    cus.DiaChi = txtDiaChi.Text;
                    cus.DT = txtDT.Text;
                    cus.Email = txtEmail.Text;
                    if (rdNam.Checked == true)
                        cus.GioiTinh = true;
                    else if (rdNu.Checked == true) cus.GioiTinh = false;
                    cus.LoaiKH = false;
                    sv.ThemKH(cus);
                    Response.Write("<script>alert('Tạo tài khoản thành công'); window.location='Index.aspx'</script>");
                }
            }
            catch { Response.Write("<script>alert('Tạo tài khoản thất bại')</script>"); }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTenKH.Text = "";
            txtNgaySinh.Text = "";
            rdNam.Checked = true;
            rdNu.Checked = false;
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
        }

        //protected void rdNam_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdNam.Checked == true)
        //        rdNu.Checked = false;
        //    else rdNu.Checked = true;
        //}

        //protected void rdNu_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdNu.Checked == true)
        //        rdNam.Checked = false;
        //    else rdNam.Checked = true;
        //}
    }
}
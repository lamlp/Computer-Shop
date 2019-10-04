using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class Account : System.Web.UI.Page
    {
        static DataTable tbCustomerID = new DataTable();
        WS.WScode sv = new WS.WScode();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cusID"] != null)
                {
                    tbCustomerID = Session["cusID"] as DataTable;
                    txtMatKhau.Visible = false;
                    txtTaiKhoan.Visible = false;
                    Label1.Text = "Khách hàng "+tbCustomerID.Rows[0][2].ToString() + " đang đăng nhập.";
                    Label2.Visible = false;
                    btnDangXuat.Visible = true;
                    btnDangNhap.Visible = false;
                    btnDangKy.Visible = false;
                }
                else
                {
                    Label1.Text = "Tài Khoản";
                    tbCustomerID.Columns.Clear();
                    tbCustomerID.Columns.Add("id", typeof(string));
                    tbCustomerID.Columns.Add("password", typeof(string));
                    tbCustomerID.Columns.Add("ten", typeof(string));
                    tbCustomerID.Columns.Add("ngaysinh", typeof(DateTime));
                    tbCustomerID.Columns.Add("gioitinh", typeof(bool));
                    tbCustomerID.Columns.Add("cmnd", typeof(string));
                    tbCustomerID.Columns.Add("diachi", typeof(string));
                    tbCustomerID.Columns.Add("dt", typeof(string));
                    tbCustomerID.Columns.Add("email", typeof(string));
                    tbCustomerID.Columns.Add("loaikh", typeof(string));
                    btnDangXuat.Visible = false;
                    btnDangNhap.Visible = true;
                    btnDangKy.Visible = true;
                }
            }
        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
                try
                {
                    DataSet ds = new DataSet();
                    WS.CustomerDTO kh = new WS.CustomerDTO();
                    kh.TaiKhoan = txtTaiKhoan.Text;
                    kh.MatKhau = txtMatKhau.Text;
                    ds = sv.DangNhap(kh);
                    tbCustomerID = ds.Tables[0];
                    if (tbCustomerID.Rows.Count > 0)
                    {
                        Session["cusID"] = tbCustomerID;
                        Response.Write("<script>alert('Đăng nhập thành công'); window.location='Index.aspx'</script>");
                    }
                    else Response.Write("<script>alert('Tài khoản hoặc Mật khẩu không chính xác')</script>");
                }
                catch { }
        }

        protected void btnDangXuat_Click(object sender, EventArgs e)
        {
            Session["cusID"] = null;
            Response.Write("<script>alert('Đăng xuất thành công'); window.location='Index.aspx'</script>");
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }
    }
}
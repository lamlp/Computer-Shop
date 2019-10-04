using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class Order : System.Web.UI.Page
    {
        DataTable tbGioHang = new DataTable();
        DataTable tbCustomerID = new DataTable();
        string strTaiKhoan;
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
             {
                 Calendar1.Visible = false;
             }
             if (Session["GioHang"] == null)
             {
                 Response.Redirect("GioHangRong.aspx");
             }
             if (Session["cusID"] != null)
             {
                 DataTable dt = Session["cusID"] as DataTable;
                strTaiKhoan = dt.Rows[0][0].ToString();
                 string taikhoanKH = dt.Rows[0][2].ToString();
                 string dienthoaiKH = dt.Rows[0][7].ToString();
                 txtTen.Text = taikhoanKH;
                 txtDienThoai.Text = dienthoaiKH;
             }
              
             tbGioHang = (DataTable)Session["GioHang"];

             string strnumber = tbGioHang.Compute("Sum(TongTien)", "").ToString();
             lbTongTien.Text = strnumber;
             gvCart.DataSource = tbGioHang;
             gvCart.DataBind();
             txtThoiGianDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //DataTable dt = Session["CusID"] as DataTable;
                    if (Session["GioHang"] == null)
                    {
                        Response.Redirect("~/GioHangRong.aspx");
                    }
                    //int ngay = int.Parse(DateTime.Now.Day.ToString());
                    //int thang = int.Parse(DateTime.Now.Month.ToString());
                    //int nam = int.Parse(DateTime.Now.Year.ToString());

                    //string[] dmy = (txtThoiGianGiao.Text).Split('/');
                    //int dd = int.Parse(dmy[0].ToString());
                    //int mm = int.Parse(dmy[1].ToString());
                    //int yy = int.Parse(dmy[2].ToString());

                    WS.WScode sv = new WS.WScode();
                    WS.OrdersDTO orders = new WS.OrdersDTO();
                    WS.MyOrdersDTO myor = new WS.MyOrdersDTO();
                    orders.TenKH = txtTen.Text;
                    orders.DienThoai = txtDienThoai.Text;
                    orders.DiaChi = txtDiaChi.Text;
                    orders.NgayTao = DateTime.Parse(txtThoiGianDat.Text);
                    orders.NgayGiao = DateTime.Parse(txtThoiGianGiao.Text);
                    orders.TrangThai = false;
                    orders.GhiChu = txtGhiChu.Text;
                    sv.TaoHoaDon(orders);
                    WS.OrdersDTO[] list = sv.LoadHoaDon();
                    DataTable t = ConvertToDataTable(list);
                    int idDH = 0;
                    foreach (DataRow r in t.Rows)
                    {
                        idDH = int.Parse(r[0].ToString());
                    }
                    myor.OrderID = idDH;
                    myor.TaiKhoan = strTaiKhoan;
                    sv.TaoMyOrder(myor);

                    if (tbGioHang.Rows.Count > 0)
                    {
                        foreach (DataRow r in tbGioHang.Rows)
                        {
                            WS.OrdersDetailDTO cthd = new WS.OrdersDetailDTO();
                            cthd.OrderID = idDH;
                            cthd.ProductID = int.Parse(r["idSP"].ToString());
                            cthd.SoLuong = int.Parse(r["SoLuong"].ToString());
                            cthd.Gia = int.Parse(r["TongTien"].ToString());
                            sv.TaoChiTietHoaDon(cthd);
                        }
                    }

                    Session["GioHang"] = null;
                    Response.Write("<script>alert('Đặt hàng thành công'); window.location='Index.aspx'</script>");
                }
                catch { }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //txtThoiGianGiao.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            DateTime date1 = DateTime.Parse(txtThoiGianDat.Text);
            DateTime date2 = Calendar1.SelectedDate;
            int kq = DateTime.Compare(date1, date2);
            if (kq < 0)
            {
                txtThoiGianGiao.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            Calendar1.Visible = false; }
            else if (kq == 0)
                Response.Write("<script>alert('Chúng tôi không thể giao hàng cho quý khách ngay trong ngày đặt hàng vui lòng chọn lại thời gian trễ hơn ít nhất 1 ngày, Cảm ơn')</script>");
            else Response.Write("<script>alert('Quý khách không thể chọn thời gian giao hàng sớm hơn thời gian đặt vui lòng chọn lại, Cảm ơn')</script>");
        }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}
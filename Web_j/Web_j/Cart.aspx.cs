using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class Cart : System.Web.UI.Page
    {
        static DataTable tbGioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ProductID"] != null)
                {
                    WS.WScode sv = new WS.WScode();
                    WS.ProductDTO pro = new WS.ProductDTO();
                    int idSP = int.Parse(Request.QueryString["ProductID"]);
                    pro.ProductID = idSP;
                    DataTable dt = sv.TimSPbyID(pro).Tables[0];
                    String TenSP = dt.Rows[0][1].ToString();
                    int Dongia = int.Parse(dt.Rows[0][2].ToString());
                    int Soluong = 1;
                    ThemVaoGioHang(idSP, TenSP, Dongia, Soluong);
                }
                if (Session["GioHang"] == null)
                {
                    Response.Redirect("GioHangRong.aspx");
                }
                tbGioHang = (DataTable)Session["GioHang"];
                string strnumber = tbGioHang.Compute("Sum(TongTien)", "").ToString();
                lbTongTien.Text = strnumber;
                gvCart.DataSource = tbGioHang;
                gvCart.DataBind();
            }
        }
        public void ThemVaoGioHang(int idSP, string TenSP, int Dongia, int Soluong)
        {
            DataTable dt;
            if (Session["GioHang"] == null)
            {
                dt = new DataTable();
                dt.Columns.Add("idSP");
                dt.Columns.Add("TenSP");
                dt.Columns.Add("Gia");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("TongTien");
            }
            else
                dt = (DataTable)Session["GioHang"];
            int dong = SPdacotronggiohang(idSP, dt);
            if (dong != -1)
            {
                dt.Rows[dong]["SoLuong"] = Convert.ToInt32(dt.Rows[dong]["SoLuong"]) + Soluong;
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr["idSP"] = idSP;
                dr["TenSP"] = TenSP;
                dr["Gia"] = Dongia;
                dr["SoLuong"] = Soluong;
                dr["TongTien"] = Dongia * Soluong;
                dt.Rows.Add(dr);
            }
            Session["GioHang"] = dt;
        }

        public static int SPdacotronggiohang(int idSP, DataTable dt)
        {
            int dong = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["idSP"].ToString()) == idSP)
                {
                    dong = i;
                    break;
                }
            }
            return dong;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Order.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["GioHang"] = null;
            Response.Write("<script>alert('Đã xóa giỏ hàng'); window.location='Index.aspx'</script>");

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            {

                //TextBox t = (TextBox)gvCart.Rows[1].Cells[3].FindControl("txtSoLuong");
                //a.Append(t.Text +"          ");

                DataTable dt = (DataTable)Session["GioHang"];
                foreach (GridViewRow r in gvCart.Rows)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (int.Parse(gvCart.DataKeys[r.DataItemIndex].Value.ToString()) == int.Parse(dr["idSP"].ToString()))
                        {
                            TextBox t = ((TextBox)r.Cells[3].FindControl("txtSoLuong"));
                            int c = int.Parse(t.Text);
                            if (c <= 0)
                                dt.Rows.Remove(dr);
                            else
                                dr["SoLuong"] = c;
                            break;
                        }
                    }
                }
                Session["Giohang"] = dt;
                Response.Write("<script>alert('Cập nhật giỏ hàng thành công'); window.location='Cart.aspx'</script>");
            }
        }

        protected void gvCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                int chiso = int.Parse(e.CommandArgument.ToString());
                try
                {
                    DataTable dt = (DataTable)Session["GioHang"];
                    dt.Rows.RemoveAt(chiso);
                    Session["GioHang"] = dt;
                    Response.Write("<script>alert('Xóa hàng thành công'); window.location='Cart.aspx'</script>");
                }
                catch
                {
                    Response.Redirect("~/Cart.aspx");
                }
            }
            //if (e.CommandName == "Sua")
            //{
            //    DataTable dt = (DataTable)Session["GioHang"];
            //    int hang = Convert.ToInt32(e.CommandArgument);
            //    string ma = gvCart.Rows[hang].Cells[0].Text;
            //    int soluong = int.Parse(((TextBox)gvCart.Rows[hang].Cells[3].Controls[1]).Text);
            //    dt.Rows[hang].SetField(3, soluong);
            //    int gia = int.Parse(gvCart.Rows[hang].Cells[2].Text);
            //    int tien = gia * soluong;
            //    dt.Rows[hang].SetField(4, tien);
            //    Session["GioHang"] = dt;
            //    gvCart.DataSource = dt;
            //    gvCart.DataBind();
            //}
        }
    }
}
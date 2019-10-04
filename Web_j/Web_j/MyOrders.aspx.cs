using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_j
{
    public partial class MyOrders : System.Web.UI.Page
    {
        WS.WScode sv = new WS.WScode();
        WS.MyOrdersDTO myor = new WS.MyOrdersDTO();
        DataTable tbCustomerID = new DataTable();
        string taikhoanKH;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cusID"] != null)
            {
                try
                {
                    DataTable dt = Session["cusID"] as DataTable;
                    taikhoanKH = dt.Rows[0][0].ToString();
                    myor.TaiKhoan = taikhoanKH;
                    gvMyorders.DataSource = sv.LoadMyOrder(myor).Tables[0];
                    gvMyorders.DataBind();
                }
                catch { }
            }
        }

        protected void gvMyorders_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xem")
            {
                try
                {
                    GridViewRow selectedRow = gvMyorders.Rows[Convert.ToInt32(e.CommandArgument)];
                    TableCell contactName = selectedRow.Cells[0];
                    int chiso = int.Parse(contactName.Text);
                    myor.OrderID = chiso;
                    myor.TaiKhoan = taikhoanKH;
                    gvChiTiet.DataSource = sv.LoadCTMyOrder(myor).Tables[0];
                    gvChiTiet.DataBind();
                }
                catch { }
            }
        }
    }
}
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
    public partial class TimeBaseDisplay : System.Web.UI.Page
    {
        static DataTable tbGioHang = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!IsPostBack)
                {
                    if (Session["GioHang"] != null)
                    {
                        tbGioHang = Session["GioHang"] as DataTable;
                    }
                    else
                    {
                        tbGioHang.Rows.Clear();
                        tbGioHang.Columns.Clear();
                        tbGioHang.Columns.Add("idSP", typeof(int));
                        tbGioHang.Columns.Add("TenSP", typeof(string));
                        tbGioHang.Columns.Add("Gia", typeof(double));
                        tbGioHang.Columns.Add("SoLuong", typeof(int));
                        tbGioHang.Columns.Add("TongTien", typeof(double), "SoLuong * Gia");
                    }
                    LoadData();
                    LoadRecomd();
                }
            }
        }
        private void LoadData()
        {
            WS.WScode sv = new WS.WScode();
            WS.ProductDTO[] list;
            list = sv.LoadTimeBase();
            DataList1.DataSource = list;
            DataList1.DataBind();
        }

        private void LoadRecomd()
        {
            WS.WScode sv = new WS.WScode();
            WS.ProductDTO[] list;

            DataTable dt = new DataTable();
            DataTable full = new DataTable();
            foreach (DataRow dr in tbGioHang.Rows)
            {
                list = sv.SP_Recommendation(dr["idSP"].ToString());
                dt = ConvertToDataTable(list);
                full.Merge(dt);
            }
            DataList2.DataSource = full;
            DataList2.DataBind();
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "GioHang")
            {
                {
                    int intidSP = int.Parse(DataList1.DataKeys[e.Item.ItemIndex].ToString());
                    string strTenSP = ((LinkButton)e.Item.FindControl("lbtProductName")).Text;
                    float flGia = float.Parse(((Label)e.Item.FindControl("lbtPrice")).Text);
                    int intSoLuong = 1;

                    //Add vao gio hang

                    foreach (DataRow row in tbGioHang.Rows)
                    {//Kiem tr neu mat hang da co roi thi tang so luong len 1
                        if ((int)row["idSP"] == intidSP)
                        {
                            row["SoLuong"] = (int)row["SoLuong"] + 1;
                            goto GioHang;
                        }
                    }
                    tbGioHang.Rows.Add(intidSP, strTenSP, flGia, intSoLuong);
                    GioHang:
                    Session["GioHang"] = tbGioHang;
                    LoadRecomd();
                    Response.Write("<script>alert('Đã thêm vào giỏ hàng')</script>");
                }

            }
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

        protected void DataList2_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "GioHang")
            {
                {
                    int intidSP = int.Parse(DataList1.DataKeys[e.Item.ItemIndex].ToString());
                    string strTenSP = ((LinkButton)e.Item.FindControl("lbtProductName")).Text;
                    float flGia = float.Parse(((Label)e.Item.FindControl("lbtPrice")).Text);
                    int intSoLuong = 1;

                    //Add vao gio hang

                    foreach (DataRow row in tbGioHang.Rows)
                    {//Kiem tr neu mat hang da co roi thi tang so luong len 1
                        if ((int)row["idSP"] == intidSP)
                        {
                            row["SoLuong"] = (int)row["SoLuong"] + 1;
                            goto GioHang;
                        }
                    }
                    tbGioHang.Rows.Add(intidSP, strTenSP, flGia, intSoLuong);
                GioHang:
                    Session["GioHang"] = tbGioHang;
                    LoadRecomd();
                    Response.Write("<script>alert('Đã thêm vào giỏ hàng')</script>");
                }

            }
        }
    }
}
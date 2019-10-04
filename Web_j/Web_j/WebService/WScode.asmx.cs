using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_j.WebService
{
    /// <summary>
    /// Summary description for WScode
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WScode : System.Web.Services.WebService
    {
        KetNoi db = new KetNoi();
        [WebMethod]
        public List<ProductDTO> LoadSP()
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string sql = "select * from Product";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ProductDTO sanPham = new ProductDTO();
                sanPham.ProductID = int.Parse(dr["ProductID"].ToString());
                sanPham.ProductName = dr["ProductName"].ToString();
                sanPham.Image = dr["Image"].ToString();
                sanPham.Price = int.Parse(dr["Price"].ToString());
                sanPham.Descriptions = dr["Descriptions"].ToString();
                list.Add(sanPham);
            }
            return list;
        }

        [WebMethod]
        public List<ProductDTO> LoadProductBySubID(SubCategoryDTO et)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string sql = @"SELECT       Product.*
FROM            SubCategoryMenu INNER JOIN
                         Product ON SubCategoryMenu.ProductID = Product.ProductID
						 WHERE SubCategoryMenu.SubCategoryID = '" + et.SubCategoryID + "'";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ProductDTO sanPham = new ProductDTO();
                sanPham.ProductID = int.Parse(dr["ProductID"].ToString());
                sanPham.ProductName = dr["ProductName"].ToString();
                sanPham.Image = dr["Image"].ToString();
                sanPham.Price = int.Parse(dr["Price"].ToString());
                sanPham.Descriptions = dr["Descriptions"].ToString();
                list.Add(sanPham);
            }
            return list;
        }
        
        [WebMethod]
        public void ThemSP(ProductDTO et)
        {
            string sql = @"INSERT INTO Product (ProductID, ProductName, Image, Price, Descriptions) VALUES (N'" + et.ProductID + "',N'" + et.ProductName + "',N'" + et.Image + "',N'" + et.Price + "',N'" + et.Descriptions + "')";
            db.ThucThiCauLenhSQL(sql);
        }

        [WebMethod]
        public void XoaSP(ProductDTO et)
        {
            string sql = @"DELETE from Product Where ProductID =N'" + et.ProductID + "'";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public int CheckExist(ProductDTO et)
        {
            DataSet d = db.GetDataSet(@"Select 1
From (
Select ProductID From SubCategoryMenu
union all
Select ProductID From TimeRule
union all
Select ProductID From OrdersDetail
union all
Select ProductID From Recommendation
) a
Where ProductID = '"+et.ProductID+"'");
            foreach (DataRow dr in d.Tables[0].Rows)
            {
                if (dr[0].ToString() == "1")
                    return 1;
            }
            return 0;
        }
        [WebMethod]
        public void SuaSP(ProductDTO et)
        {
            string sql = @"UPDATE Product SET ProductName = N'" + et.ProductName + "', Image = N'" + et.Image + "', Price =N'" + et.Price + "', Descriptions =N'" + et.Descriptions + "' Where ProductID = '" + et.ProductID + "'";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public DataSet TimSP(ProductDTO et)
        {
            return db.GetDataSet(@"Select * from Product Where ProductName Like '%"+et.ProductName+"%'");
        }
        [WebMethod]
        public DataSet TimSPbyID(ProductDTO et)
        {
            return db.GetDataSet(@"Select * from Product Where ProductID = '" + et.ProductID + "'");
        }
        //--Hóa Đơn
        [WebMethod]
        public List<OrdersDTO> LoadHoaDon()
        {
            List<OrdersDTO> list = new List<OrdersDTO>();
            string sql = "select * from Orders";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                OrdersDTO hoaDon = new OrdersDTO();
                hoaDon.OrderID = int.Parse(dr["OrderID"].ToString());
                hoaDon.TenKH = dr["TenKH"].ToString();
                hoaDon.DienThoai = dr["DienThoai"].ToString();
                hoaDon.DiaChi = dr["DiaChi"].ToString();
                hoaDon.NgayTao = DateTime.Parse(dr["NgayTao"].ToString());
                hoaDon.NgayGiao = DateTime.Parse(dr["NgayGiao"].ToString());
                hoaDon.TrangThai = bool.Parse(dr["TrangThai"].ToString());
                hoaDon.GhiChu = dr["GhiChu"].ToString();
                list.Add(hoaDon);
            }
            return list;
        }

        [WebMethod]
        public void TaoHoaDon(OrdersDTO et)
        {
            string sql = @"INSERT INTO Orders (TenKH, DienThoai, DiaChi, NgayTao, NgayGiao, TrangThai, GhiChu) VALUES (N'" + et.TenKH + "', N'" + et.DienThoai + "', N'" + et.DiaChi + "', '" + et.NgayTao.ToString("yyyy-MM-dd") + "', '" + et.NgayGiao.ToString("yyyy-MM-dd") + "', '" + et.TrangThai + "', N'" + et.GhiChu + "')";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void XoaHoaDon(OrdersDTO et)
        {
            string sql = @"DELETE from Orders Where OrderID ='" + et.OrderID + "'";
            string sql2 = @"DELETE from OrdersDetail Where OrderID = '"+et.OrderID+"'";
            db.ThucThiCauLenhSQL(sql2);
            db.ThucThiCauLenhSQL(sql);

        }
        [WebMethod]
        public void SuaHoaDon(OrdersDTO et)
        {
            string sql = @"UPDATE Orders SET TenKH =N'"+et.TenKH+"', DienThoai ='"+et.DienThoai+"', DiaChi =N'"+et.DiaChi+"', NgayTao ='" + et.NgayTao.ToString("yyyy-MM-dd") + "', NgayGiao ='" + et.NgayGiao.ToString("yyyy-MM-dd")+"', GhiChu =N'"+et.GhiChu+"' Where OrderID ='" + et.OrderID + "'";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void ActiveHoaDon(OrdersDTO et)
        {
            string sql = @"UPDATE Orders SET TrangThai =N'" + et.TrangThai + "' Where OrderID =N'" + et.OrderID + "'";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public DataSet LoadChiTietHoaDon(OrdersDetailDTO et)
        {
            return db.GetDataSet(@"Select ProductName, Price, SoLuong, Gia
From Product Inner join OrdersDetail on Product.ProductID = OrdersDetail.ProductID
Where OrderID ='"+et.OrderID+"'");
        }
        [WebMethod]
        public void TaoChiTietHoaDon(OrdersDetailDTO et)
        {
            string sql = @"INSERT INTO OrdersDetail (OrderID, ProductID, SoLuong, Gia) VALUES (N'"+et.OrderID+"', N'"+et.ProductID+"', N'"+et.SoLuong+"', N'"+et.Gia+"')";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void SuaChiTietHoaDon(OrdersDetailDTO et)
        {
            string sql = @"UPDATE OrdersDetail SET ProductID = '"+et.ProductID+"', SoLuong = '"+et.SoLuong+"', Gia = '"+et.Gia+ "' Where OrderID = '" + et.OrderID + "'";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void XoaChiTietHoaDon(OrdersDetailDTO et)
        {
            string sql = @"DELETE From OrdersDetail Where OrderID = '"+ et.OrderID+"' And ProductID = '"+et.ProductID+"'";
            db.ThucThiCauLenhSQL(sql);
        }
        //--My Order
        [WebMethod]
        public void TaoMyOrder(MyOrdersDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO MyOrders (TaiKhoan, OrderID) VALUES (N'"+et.TaiKhoan+"', "+et.OrderID+")");
        }
        [WebMethod]
        public DataSet LoadMyOrder(MyOrdersDTO et)
        {
            return db.GetDataSet(@"Select Orders.OrderID, Orders.NgayTao, Orders.NgayGiao, Orders.GhiChu, Sum(OrdersDetail.Gia * OrdersDetail.SoLuong) as TongTien, Orders.TrangThai from Orders Inner join MyOrders On Orders.OrderID = MyOrders.OrderID Inner join OrdersDetail On Orders.OrderID = OrdersDetail.OrderID  Where MyOrders.TaiKhoan = N'"+et.TaiKhoan+"' Group by Orders.OrderID,Orders.NgayTao,Orders.NgayGiao,Orders.GhiChu,Orders.TrangThai");
        }
        [WebMethod]
        public DataSet LoadCTMyOrder(MyOrdersDTO et)
        {
            return db.GetDataSet(@"Select ProductName, Image, Price, SoLuong,
        (Price * SoLuong) as TongTien
        From Product Inner join OrdersDetail on Product.ProductID = OrdersDetail.ProductID
		Inner join MyOrders On OrdersDetail.OrderID = MyOrders.OrderID 
        Where MyOrders.TaiKhoan=N'"+et.TaiKhoan+"' And MyOrders.OrderID = N'"+et.OrderID+"'");
        }
        //--Category

        [WebMethod]
        public void TaoCategory(CategoryDTO et)
        {
            string sql = @"INSERT INTO Category (CategoryName) VALUES (N'" + et.CategoryName + "')";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void SuaCategory(CategoryDTO et)
        {
            db.ThucThiCauLenhSQL(@"Update Category Set CategoryName = '"+et.CategoryName+"' Where CategoryID = '"+et.CategoryID+"'");
        }
        [WebMethod]
        public void XoaCategory(CategoryDTO et)
        {
            db.ThucThiCauLenhSQL(@"Delete Category Where CategoryID = '"+et.CategoryID+"'");
        }
        [WebMethod]
        public void TaoSubCategory(SubCategoryDTO et)
        {
            string sql = @"INSERT INTO SubCategory (SubCategoryName, CategoryID) VALUES (N'" + et.SubCategoryName + "','" + et.CategoryID + "')";
            db.ThucThiCauLenhSQL(sql);
        }
        [WebMethod]
        public void SuaSubCategory(SubCategoryDTO et)
        {
            db.ThucThiCauLenhSQL(@"Update SubCategory Set SubCategoryName = '"+et.SubCategoryName+"', CategoryID = '"+et.CategoryID+"' Where SubCategoryID = '"+et.SubCategoryID+"'");
        }
        [WebMethod]
        public void XoaSubCategory(SubCategoryDTO et)
        {
            db.ThucThiCauLenhSQL(@"Delete SubCategory Where SubCategoryID = '" + et.SubCategoryID + "'");
        }
        [WebMethod]
        public void ThemSPVaoSubCateMenu(SubCategoryMenuDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO SubCategoryMenu (SubCategoryID, ProductID) VALUES ('" + et.SubCategoryID + "', '" + et.ProductID + "')");
        }

        [WebMethod]
        public DataSet LoadCategory()
        {
            return db.GetDataSet("select * from Category");
        }

        [WebMethod]
        public DataSet LoadSubCategory()
        {
            return db.GetDataSet("select * from SubCategory");
        }
        [WebMethod]
        public DataSet LoadSubCategoryByCateID(SubCategoryDTO et)
        {
            return db.GetDataSet(@"Select * from SubCategory where CategoryID = '" + et.CategoryID + "'");
        }
        [WebMethod]
        public void XoaSPSub(SubCategoryMenuDTO et)
        {
            db.ThucThiCauLenhSQL(@"Delete from SubCategoryMenu where SubCategoryID = '"+et.SubCategoryID+"' and ProductID= '"+et.ProductID+"'");
        }
        //--Recommend

        [WebMethod]
        public List<ProductDTO> SP_Recommendation(string reID)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            string sql = @"Select Product.*
                                    From Product, Recommendation
                                    Where Product.ProductID = Recommendation.ProductID and Recommendation.ReProductID='"+reID+"'";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                ProductDTO sanPham = new ProductDTO();
                sanPham.ProductID = int.Parse(dr["ProductID"].ToString());
                sanPham.ProductName = dr["ProductName"].ToString();
                sanPham.Image = dr["Image"].ToString();
                sanPham.Price = int.Parse(dr["Price"].ToString());
                sanPham.Descriptions = dr["Descriptions"].ToString();
                list.Add(sanPham);
            }
            return list;
        }
        [WebMethod]
        public void Add_Recommendation(RecommendationDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO Recommendation (ReProductID, ProductID) VALUES ('"+et.ReProductID+"', '"+et.ProductID+"')");
        }
        [WebMethod]
        public void Xoa_Recommendation(RecommendationDTO et)
        {
            db.ThucThiCauLenhSQL(@"DELETE from Recommendation Where ReProductID = '"+et.ReProductID+"' And ProductID = '"+et.ProductID+"'");
        }

        //--Khách Hàng

        [WebMethod]
        public List<CustomerDTO> LoadKH()
        {
            List<CustomerDTO> list = new List<CustomerDTO>();
            string sql = "select * from Customer";
            DataTable dt = new DataTable();
            dt = db.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                CustomerDTO khachHang = new CustomerDTO();
                khachHang.TaiKhoan = dr["TaiKhoan"].ToString();
                khachHang.MatKhau = dr["MatKhau"].ToString();
                khachHang.TenKH = dr["TenKH"].ToString();
                khachHang.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                khachHang.GioiTinh = bool.Parse(dr["GioiTinh"].ToString()); ;
                khachHang.CMND = dr["CMND"].ToString();
                khachHang.DiaChi = dr["DiaChi"].ToString();
                khachHang.DT = dr["DT"].ToString();
                khachHang.Email = dr["Email"].ToString();
                khachHang.LoaiKH = bool.Parse(dr["LoaiKH"].ToString());
                list.Add(khachHang);
            }
            return list;
        }
        [WebMethod]
        public void ThemKH(CustomerDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO Customer (TaiKhoan, MatKhau, TenKH, NgaySinh, GioiTinh, CMND, DiaChi, DT, Email, LoaiKH) VALUES (N'" + et.TaiKhoan + "', N'" + et.MatKhau + "', N'" + et.TenKH + "', N'" + et.NgaySinh.ToString("yyyy-MM-dd") + "', N'" + et.GioiTinh + "', N'" + et.CMND + "', N'" + et.DiaChi + "', N'" + et.DT + "', N'" + et.Email + "', N'" + et.LoaiKH + "')");
        }
        [WebMethod]
        public void XoaKH(CustomerDTO et)
        {
            db.ThucThiCauLenhSQL(@"DELETE from Customer Where TaiKhoan = N'" + et.TaiKhoan + "'");
        }
        [WebMethod]
        public void SuaKH(CustomerDTO et)
        {
            db.ThucThiCauLenhSQL(@"UPDATE Customer SET MatKhau = N'" + et.MatKhau + "', TenKH = N'" + et.TenKH + "', NgaySinh = N'" + et.NgaySinh.ToString("yyyy-MM-dd") + "', GioiTinh = '" + et.GioiTinh + "', CMND = N'" + et.CMND + "', DiaChi = N'" + et.DiaChi + "', DT = N'" + et.DT + "', Email = N'" + et.Email + "', LoaiKH = N'" + et.LoaiKH + "' Where TaiKhoan = '" + et.TaiKhoan + "'");
        }
        [WebMethod]
        public DataSet TimKH(CustomerDTO et)
        {
            return db.GetDataSet(@"Select * from Customer where TaiKhoan Like N'%"+et.TaiKhoan+"%'");
        }
        [WebMethod]
        public int CheckKH(CustomerDTO et)
        {
            DataTable dt = db.GetDataTable(@"Select * from Customer Where TaiKhoan = N'"+et.TaiKhoan+"'");
            if (dt.Rows.Count != 0)
                return 1;
            else return 0;
        }
        [WebMethod]
        public DataSet DangNhapAdmin(string taikhoan, string matkhau)
        {
            return db.GetDataSet(@"Select * from Admin where TaiKhoan=N'"+taikhoan+"' and MatKhau =N'"+matkhau+"'");
        }
        [WebMethod]
        public DataSet DangNhap(CustomerDTO et)
        {
            return db.GetDataSet(@"Select * from Customer where TaiKhoan=N'"+et.TaiKhoan+"' and MatKhau=N'"+et.MatKhau+"'");
        }
        [WebMethod]
        public void DoiMatKhau(CustomerDTO et)
        {
            db.ThucThiCauLenhSQL(@"UPDATE Customer Set MatKhau= N'"+et.MatKhau+"' where TaiKhoan= '"+et.TaiKhoan+"'");
        }
        //--Timebase
        [WebMethod]
        public DataSet LoadTimeBaseDisplay()
        {
            return db.GetDataSet(@"select * from TimeBaseDisplay");
        }
        [WebMethod]
        public DataSet LoadTimeBaseByID(TimeRuleDTO et)
        {
            return db.GetDataSet(@"select Product.* from TimeRule inner join Product on TimeRule.ProductID = Product.ProductID Where TimeID = '" + et.TimeID + "'");
        }

        [WebMethod]
        public void ThemTimeBaseDisplay(TimeBaseDisplayDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO TimeBaseDisplay (FromTime, ToTime, FromHour, ToHour, DayOfWeek) VALUES ('" + et.FromTime.ToString("yyyy-MM-dd") + "', '" + et.ToTime.ToString("yyyy-MM-dd") + "', '" + et.FromHour.ToString("HH:mm:ss") + "', '" + et.ToHour.ToString("HH:mm:ss") + "', '" + et.DayOfWeek + "')");
        }
        [WebMethod]
        public void SuaTimeBaseDisplay(TimeBaseDisplayDTO et)
        {
            db.ThucThiCauLenhSQL(@"UPDATE TimeBaseDisplay SET FromTime = '" + et.FromTime.ToString("yyyy-MM-dd") + "', ToTime = '" + et.ToTime.ToString("yyyy-MM-dd") + "', FromHour = '" + et.FromHour.ToString("HH:mm:ss") + "', ToHour = '" + et.ToHour.ToString("HH:mm:ss") + "', DayOfWeek = '" + et.DayOfWeek + "' Where TimeID = '"+et.TimeID+"'");
        }
        [WebMethod]
        public void XoaTimeBaseDisplay(TimeBaseDisplayDTO et)
        {
            db.ThucThiCauLenhSQL(@"DELETE FROM TimeBaseDisplay Where TimeID = '" + et.TimeID + "'");
        }
        [WebMethod]
        public void AddTimeRule(TimeRuleDTO et)
        {
            db.ThucThiCauLenhSQL(@"INSERT INTO TimeRule (TimeID, ProductID) VALUES (N'" + et.TimeID + "', N'" + et.ProductID + "')");
        }
        [WebMethod]
        public void XoaTimeRule(TimeRuleDTO et)
        {
            db.ThucThiCauLenhSQL(@"DELETE TimeRule Where TimeID = '" + et.TimeID + "' And ProductID = '" +et.ProductID + "'");
        }
        [WebMethod]
        public List<ProductDTO> LoadTimeBase()
        {
            List<ProductDTO> list = new List<ProductDTO>();
            DataTable dt = new DataTable();
            DateTime cur = DateTime.Now;
            int i = (int)cur.DayOfWeek + 1;
            dt = db.GetDataTable(@"SELECT Product.* FROM TimeRule Inner join Product On TimeRule.ProductID = Product.ProductID Inner join TimeBaseDisplay On TimeRule.TimeID = TimeBaseDisplay.TimeID WHERE '" + cur.Date.ToString("yyyy-MM-dd") + "' between TimeBaseDisplay.FromTime And TimeBaseDisplay.ToTime And " + i + " = TimeBaseDisplay.DayOfWeek And '" + cur.ToString("HH:mm:ss") + "' between CONVERT(VARCHAR(8),TimeBaseDisplay.FromHour,108) And CONVERT(VARCHAR(8),TimeBaseDisplay.ToHour,108)");
            foreach (DataRow dr in dt.Rows)
            {
                ProductDTO sanPham = new ProductDTO();
                sanPham.ProductID = int.Parse(dr["ProductID"].ToString());
                sanPham.ProductName = dr["ProductName"].ToString();
                sanPham.Image = dr["Image"].ToString();
                sanPham.Price = int.Parse(dr["Price"].ToString());
                sanPham.Descriptions = dr["Descriptions"].ToString();
                list.Add(sanPham);
            }
            return list;
        }
    }
}


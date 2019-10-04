<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Web_j.Account" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="Web_j.Account" %>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div>
            <asp:Panel ID="p" runat="server" DefaultButton="btnDangNhap">
            <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
            <p><asp:TextBox runat="server" ID="txtTaiKhoan"></asp:TextBox></p>
            <p><asp:Label ID="Label2" runat="server" Text="Mật Khẩu"></asp:Label></p>
            <p><asp:TextBox runat="server" ID="txtMatKhau" TextMode="Password"></asp:TextBox></p>
            <asp:Button runat="server" ID="btnDangNhap" Text="Đăng Nhập" OnClick="btnDangNhap_Click" />
            <asp:Button runat="server" ID="btnDangKy" Text="Đăng Ký" OnClick="btnDangKy_Click" />
            <asp:Button runat="server" ID="btnDangXuat" Text="Đăng Xuất" OnClick="btnDangXuat_Click" />
                            </asp:Panel>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menungang" runat="server">
    <%--                  <%
                      Web_j.WS.WScode sv = new Web_j.WS.WScode();
                      System.Data.DataSet ds1 = sv.LoadCategory();
                      System.Data.DataSet ds2 = sv.LoadSubCategory();
                      System.Data.DataTable dt1 = ds1.Tables[0];
                      System.Data.DataTable dt2 = ds2.Tables[0];
                      
                      StringBuilder full = new StringBuilder();
                      StringBuilder cate = new StringBuilder();
                      StringBuilder sub = new StringBuilder();
                      string subc = "";
                      foreach (System.Data.DataRow dr in dt1.Select("CategoryID >" + 0))
                      {
                          StringBuilder half = new StringBuilder();
                          foreach (System.Data.DataRow dr2 in dt2.Select("CategoryID =" + Int32.Parse(dr["CategoryID"].ToString())))
                          {
                              sub.Append("<li><a href=" + "Index.aspx?SubCategoryID=" + dr2["SubCategoryID"].ToString() + ">" + dr2["SubCategoryName"].ToString() + "</a></li>");
                          }
                          subc = sub.ToString();
                          sub.Clear();
                          half.Append("<ul>" + subc + "</ul>");
                          cate.Append("<li><a>" + dr["CategoryName"].ToString() + "</a>" + half + "</li>");
                      }
                      full.Append("<ul>" + cate + "</ul>");
                      Response.Write(full);
                  %>--%>
                   
</asp:Content>


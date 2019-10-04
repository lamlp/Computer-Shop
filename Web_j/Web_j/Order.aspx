<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Web_j.Order" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Web_j.Order" %>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div>
        <img src="Image/thongtingiohang.gif" style="width: 256px; height: 61px" />&nbsp;
    <asp:GridView 
        ID="gvCart" runat="server" Width="750px" AutoGenerateColumns="False"
        ForeColor="#333333" Height="201px" DataKeyNames="idSP"
       >
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" BorderColor="Black" BorderWidth="1px" 
            ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="idSP" HeaderText="ID"/>
            <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="Gia" HeaderText="Giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>    
        <div style="padding-left:415px;padding-top:7px;margin-top:3px;border:1px solid black;height:30px; font-size:11pt">
            <b>Tổng tiền thanh toán là:&nbsp;&nbsp</b><asp:Label ID="lbTongTien" runat="server" 
                Font-Bold="True" Font-Italic="False" ForeColor="#CC0000"></asp:Label>   
            <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="VNĐ"></asp:Label>
        </div>   
    </div>
        <div class="aaa">
            <h2>Thông Tin Đơn Hàng</h2>
            <div class="bbb">
            <p><strong>Tên Người Nhận:</strong></p>
            <p><strong>Điện Thoại:</strong></p> 
            <p><strong>Địa Chỉ Giao Hàng:</strong></p>
            <p><strong>Thời Gian Đặt Hàng:</strong></p>
            <p><strong>Thời Gian Giao Hàng:</strong></p>
            <p><strong>Ghi Chú:</strong></p>
            </div>
            <div class="ccc">
            <p><asp:TextBox ID="txtTen" runat="server" Width="220px"></asp:TextBox></p>
            <p><asp:TextBox ID="txtDienThoai" runat="server" Width="220px"></asp:TextBox></p>
            <p><asp:TextBox ID="txtDiaChi" runat="server" Width="220px"></asp:TextBox></p>
            <p><asp:TextBox ID="txtThoiGianDat" runat="server" Width="220px" ReadOnly="true"></asp:TextBox></p>
            <p><asp:TextBox ID="txtThoiGianGiao" runat="server" Width="220px" ReadOnly="true"></asp:TextBox><asp:Button ID="Button3" runat="server" Text="Chọn" OnClick="Button3_Click"/></p>
            <p><asp:TextBox ID="txtGhiChu" runat="server" Width="220px"></asp:TextBox></p>
            <p><asp:Button ID="Button1" runat="server" Text="Thanh Toán" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Trở Về" OnClick="Button2_Click" /></p>
            </div>
            <div class="ddd">
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </div>
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Menungang" runat="server">
                
                   
</asp:Content>

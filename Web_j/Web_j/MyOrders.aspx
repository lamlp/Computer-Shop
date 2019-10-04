<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="MyOrders.aspx.cs" Inherits="Web_j.MyOrders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menungang" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <asp:GridView 
        ID="gvMyorders" runat="server" Width="750px" AutoGenerateColumns="False"
        ForeColor="#333333" Height="201px" OnRowCommand="gvMyorders_RowCommand"  DataKeyNames="OrderID"
       >
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" BorderColor="Black" BorderWidth="1px" 
            ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="OrderID" HeaderText="ID"/>
            <asp:BoundField DataField="NgayTao" HeaderText="Ngày Tạo" />
            <asp:BoundField DataField="NgayGiao" HeaderText="Ngày Giao" />
            <asp:BoundField DataField="GhiChu" HeaderText="Ghi Chú" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
            <asp:CheckBoxField DataField="TrangThai" HeaderText="Đã Thanh Toán" />
            <asp:ButtonField CommandName="Xem" HeaderText="Chi Tiết" Text="Xem" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
        <asp:GridView 
        ID="gvChiTiet" runat="server" Width="750px" AutoGenerateColumns="False"
        ForeColor="#333333" Height="201px"
       >
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" BorderColor="Black" BorderWidth="1px" 
            ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="Tên"/>
             <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    <img src="<%# Eval("Image") %>" width="250" height="170">
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Price" HeaderText="Đơn Giá" />
            <asp:BoundField DataField="Price" HeaderText="Đơn Giá" />
            <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="recomd" runat="server">
</asp:Content>

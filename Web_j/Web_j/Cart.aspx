<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Web_j.Cart" %>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Web_j.Cart" %>



<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div>
        <img src="Image/thongtingiohang.gif" style="width: 256px; height: 61px" />&nbsp;
    <asp:GridView 
        ID="gvCart" runat="server" Width="750px" AutoGenerateColumns="False"
        ForeColor="#333333" Height="201px" OnRowCommand="gvCart_RowCommand" DataKeyNames="idSP"
       >
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" BorderColor="Black" BorderWidth="1px" 
            ForeColor="White" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <Columns>
            <asp:BoundField DataField="idSP" HeaderText="ID" />
            <asp:BoundField DataField="TenSP" HeaderText="Tên Sản Phẩm" />
            <asp:BoundField DataField="Gia" HeaderText="Giá" />
                        <asp:TemplateField HeaderText="Số lượng">
                <ItemTemplate>
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtSoLuong" runat="server" Text='<%# Bind ("SoLuong") %>'
                        Width="30px"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" />
            <asp:ButtonField CommandName="Xoa" HeaderText="Xóa" Text="Xóa" />
            <%--<asp:ButtonField CommandName="Sua" HeaderText="Sửa" Text="Sửa" />--%>



        </Columns>
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:GridView>    
        <div style="padding-left:415px;padding-top:7px;margin-top:3px;border:1px solid black;height:30px; font-size:11pt">
            <b>Tổng tiền thanh toán là:&nbsp;&nbsp</b><asp:Label ID="lbTongTien" runat="server" 
                Font-Bold="True" Font-Italic="False" ForeColor="#CC0000"></asp:Label>   
            <asp:Label ID="Label1" runat="server" ForeColor="#CC0000" Text="VNĐ"></asp:Label>
        </div>   
        <div style="height:20px;">
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Image/icon update.ico" width ="50" Height ="40" OnClick="ImageButton3_Click"/>
            <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/Image/icon xoa.ico" width ="50" Height ="40" OnClick="ImageButton4_Click"/>
        </div>
        <div style="width:350px; padding-left:480px;">
        <div style="float:left; margin-right:20px;">
            <asp:ImageButton ID="ImageButton1" runat="server" 
                ImageUrl="~/Image/tieptucmuahang.bmp" OnClick="ImageButton1_Click" /></div>             
        <div>
            <asp:ImageButton ID="ImageButton2" runat="server" 
                ImageUrl="~/Image/thanh toan.jpg" onclick="ImageButton2_Click" /></div>
        </div>       
    </div>
    </asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Menungang" runat="server">
                 
                   
</asp:Content>

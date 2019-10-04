<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="Web_j.ProductDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menungang" runat="server">
                
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <asp:DataList ID ="dtProduct" runat="server">
        <ItemTemplate>
            <img src="<%# Eval("Image") %>" width="330" height="190">
                        <h4 class="margin-bottom">
                            <div style="width:100%;height:40px; ">                    
                    <asp:Label ID="Label1" runat="server" ForeColor="Black"
                                        Text='<%# Eval("ProductName") %>' />
                            <br /> <asp:Label ID="lbtPrice" runat="server" ForeColor="Black"
                                        Text='<%# Eval("Price") %>' /> VNĐ</h4>
                           <div>
                               <asp:Button ID="Button1" runat="server" Cssclass="button rounded-btn submit-btn" CommandName="GioHang" Text="Add to cart" />
                           </div>
                                <asp:Label ID="Label2" runat="server" ForeColor="Black"
                                        Text='<%# Eval("Descriptions") %>' />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

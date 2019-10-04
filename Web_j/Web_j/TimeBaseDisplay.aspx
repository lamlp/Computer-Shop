<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="TimeBaseDisplay.aspx.cs" Inherits="Web_j.TimeBaseDisplay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menungang" runat="server">
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <div class="margin">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" Width="100%" OnItemCommand="DataList1_ItemCommand" DataKeyField="ProductID">
        <ItemTemplate >                                    
        <%--<div class="s-12 m-6 l-4">--%>
                        <img src="<%# Eval("Image") %>" width="330" height="190">
                        <h4 class="margin-bottom">
                            <div style="width:100%;height:40px; ">                    
                    <asp:LinkButton ID="lbtProductName" runat="server" Text='<%# Eval("ProductName") %>'
                        PostBackUrl='<%# "ProductDetails.aspx?ProductID="+ Eval("ProductID") %>' 
                        Font-Bold="True" Font-Size="Medium" 
                        Font-Underline="True" ForeColor="#0066FF"></asp:LinkButton> 
                            <br /> <asp:Label ID="lbtPrice" runat="server" ForeColor="Black"
                                        Text='<%# Eval("Price") %>' /> VNĐ</h4>
                           <div>
                               <asp:Button ID="Button1" runat="server" class="button rounded-btn submit-btn s-12" CommandName="GioHang" Text="Add to cart" />
                           </div>
                     <%--</div>   --%>                              
        </ItemTemplate>
    </asp:DataList>
                </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="recomd" runat="server">
    <asp:DataList ID="DataList2" runat="server" RepeatColumns="1" Width="100%" DataKeyField="ProductID" OnItemCommand="DataList2_ItemCommand">
            <ItemTemplate>
                                        <img src="<%# Eval("Image") %>" width="330" height="190">
                        <h4 class="margin-bottom">
                            <div style="width:100%;height:40px; ">                    
                    <asp:LinkButton ID="lbtProductName" runat="server" Text='<%# Eval("ProductName") %>'
                        PostBackUrl='<%# "ProductDetails.aspx?ProductID="+ Eval("ProductID") %>' 
                        Font-Bold="True" Font-Size="Medium" 
                        Font-Underline="True" ForeColor="#0066FF"></asp:LinkButton> 
                            <br /> <asp:Label ID="lbtPrice" runat="server" ForeColor="Black" 
                                        Text='<%# Eval("Price") %>' /> VNĐ</h4>
                                           <div>
                               <asp:Button ID="Button1" runat="server" class="button rounded-btn submit-btn s-12" CommandName="GioHang" Text="Add to cart" />
                           </div>
            </ItemTemplate>
        </asp:DataList>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/TrangChu.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Web_j.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Menungang" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <div>
        <div class="aaa">
            <h2>Đăng Ký</h2>
<div class="bbb">
<p><strong>Tài Khoản:</strong></p>
<p><strong>Mật Khẩu:</strong></p> 
<p><strong>Tên:</strong></p>
<p><strong>Ngày Sinh:</strong></p>
<p><strong>Giới Tính:</strong></p>
<p><strong>CMND:</strong></p>
<p><strong>Địa Chỉ:</strong></p>
<p><strong>Điện Thoại:</strong></p>
<p><strong>Email:</strong></p>
</div>
<div class="ccc">
<p><asp:TextBox ID="txtTaiKhoan" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:TextBox ID="txtMatKhau" runat="server" Width="220px" TextMode="Password"></asp:TextBox></p>
<p><asp:TextBox ID="txtTenKH" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:TextBox ID="txtNgaySinh" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:RadioButton GroupName="gioitinh" ID="rdNam" Text="Nam" runat="server" /><asp:RadioButton GroupName="gioitinh" ID="rdNu" Text="Nữ" runat="server" /></p>
<p><asp:TextBox ID="txtCMND" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:TextBox ID="txtDiaChi" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:TextBox ID="txtDT" runat="server" Width="220px"></asp:TextBox></p>
<p><asp:TextBox ID="txtEmail" runat="server" Width="220px"></asp:TextBox></p>
<p> <asp:Button runat="server" ID="btnDangKy" Text="Xác Nhận" OnClick="btnDangKy_Click" />
<asp:Button ID="Button2" runat="server" Text="Hủy Bỏ" OnClick="Button2_Click" /></p>
</div>
</div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="recomd" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="WebBanDT.DangKy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100px;
        }
        .style3
        {
            width: 406px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:MultiView ID="multiview1" runat="server">
<asp:View ID="view1" runat="server">
 <table align="center" style=" width:501px; margin-left: 85px;">
      <tr style=" height:30px;">
          <td align="center">
                
          </td>
          <td class="style3">
               <asp:Label ID="lbTT" runat="server"  Font-Size="Larger" ForeColor="Red" Text="Bạn chưa có tài khoản? hãy đăng ký để có thể mua hàng" ></asp:Label>
          </td>
      </tr>
      <tr>
          <td align="left" class="style2">
            Tên Tài Khoản
          </td>
          <td align="left" class="style3">
             <asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="20px"></asp:TextBox>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                  ControlToValidate="txtEmail" ErrorMessage="Tài Khoản không đúng" ForeColor="Red" 
                  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
          </td>
                                             
      </tr>
      <tr style=" height:30px;">
         <td>
            Mật khẩu
         </td>
         <td class="style3">
             <asp:TextBox ID="txtMatkhau" runat="server" Width="200px" Height="20px" 
                 TextMode="Password"></asp:TextBox>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                 ControlToValidate="txtMatkhau" ErrorMessage="Chưa nhập mật khẩu" 
                 ForeColor="Red"></asp:RequiredFieldValidator>
         </td>
     </tr>
     <tr style=" height:30px;">
         <td>
            Nhập lại mật khẩu
         </td>
         <td class="style3">
             <asp:TextBox ID="txtMatKhau1" runat="server" Width="200px" Height="20px" 
                 TextMode="Password"></asp:TextBox>
             <asp:CompareValidator ID="CompareValidator1" runat="server" 
                 ControlToCompare="txtMatkhau" ControlToValidate="txtMatKhau1" 
                 ErrorMessage="Mật khẩu không trùng nhau" ForeColor="Red"></asp:CompareValidator>
         </td>
     </tr>
     <tr>
          <td>
                Họ và Tên
          </td>
          <td class="style3">
                <asp:TextBox ID="txtHoTen" runat="server" Width="200px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtHoTen" ErrorMessage="Chưa nhập họ tên" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
     </tr>
      <tr>
          <td>
                Địa chỉ
          </td>
          <td class="style3">
                <asp:TextBox ID="txtDiaChi" runat="server" Width="200px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtDiaChi" ErrorMessage="Chưa nhập địa chỉ" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
     </tr>
      <tr>
          <td>
                Số điện thoại
          </td>
          <td class="style3">
                <asp:TextBox ID="txtSoDT" runat="server" Width="200px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtSoDT" ErrorMessage="Chưa nhập số điện thoại" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
     </tr>
      <tr>
          <td>
                Số fax
          </td>
          <td class="style3">
                <asp:TextBox ID="txtSofax" runat="server" Width="200px" Height="20px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtSofax" ErrorMessage="Chưa nhập số fax" ForeColor="Red"></asp:RequiredFieldValidator>
          </td>
     </tr>
     <tr>
           <td>
           </td>
           <td class="style3"><asp:Button ID="btnDangKy" runat="server" OnClick="DangKy_Click" Width="100px"  Height="30px" Text="Đăng Ký"/></td>
     </tr>
     <tr><td></td><td><asp:Label ID="lbtest" runat="server"></asp:Label></td></tr>
</table>
</asp:View>
<asp:View ID="view2" runat="server">
<table  style=" width:100%;">
<tr style=" height:50px;">
     <td>
        
     </td>
</tr>
<tr>
    <td align="center">
        <asp:Label ID="lb1" runat="server" Text="Đăng ký thành công" ForeColor="Red" Font-Size="X-Large"></asp:Label>
    </td>
</tr>
<tr>
    <td align="center">
        <p>
           Bạn có thể sử dụng tài khoản để đăng nhập và mua hàng trên website<br />
           Mua hàng trực tuyến để có thể sở hữu những sản phẩm thông minh với<br />
           giá tốt nhất.
        </p>
    </td>
</tr>
<tr>
   <td align="center" style=" text-decoration:none;">
       <asp:HyperLink ID="hp1" runat="server" Text="Bấm vào đây để trờ về trang chủ" ForeColor="Blue" NavigateUrl="~/TrangChu.aspx"></asp:HyperLink>
   </td>
</tr>
</table>
</asp:View>
</asp:MultiView>
</asp:Content>

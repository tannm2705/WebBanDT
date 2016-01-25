<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="ThacMac.aspx.cs" Inherits="WebBanDT.ThacMac" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:MultiView ID="multiview1" runat="server" >
  <asp:View ID="view1" runat="server">
      <table style=" width:100%;">
         <tr>
            <td colspan="2" align="center">
                <h2 style=" color:Red;">Thắc mắc hoặc ý kiến của bạn</h2>
            </td>
         </tr>
         <tr>
           <td colspan="2" align="center">
             <h4 style=" color:Blue;">Thông tin dưới đây là bắt buộc bạn hãy nhập đầy đủ</h4>
           </td>
         </tr>
         <tr>
           <td align="right">
             Địa chỉ người nhận:
           </td>
           <td align="left">
              <asp:TextBox ID="txtNguoiNhan" runat="server" Width="400px"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                   ControlToValidate="txtNguoiNhan" ErrorMessage="Chưa nhập địa chỉ" 
                   ForeColor="Red"></asp:RequiredFieldValidator>
           </td>
         </tr>
         <tr>
            <td align="right">
                Tiêu đề:
            </td>
            <td align="left">
              <asp:TextBox ID="txtTieuDe" runat="server" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtTieuDe" ErrorMessage="Chưa nhập tiêu đề" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
             <td align="right">
               Nội dung:
             </td>
             <td align="left">
               <asp:TextBox ID="txtNoiDung" runat="server" Width="400px" Height="100px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                     ControlToValidate="txtNoiDung" ErrorMessage="Chưa nhập nội dung" 
                     ForeColor="Red"></asp:RequiredFieldValidator>
             </td>
         </tr>
         <tr>
            <td align="right">
               Email của bạn:
            </td>
            <td align="left">
              <asp:TextBox ID="txtEmailYou" runat="server" Width="400px" ></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmailYou" ErrorMessage="Không đúng định dạng" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <td align="right">
                Mật khẩu Email:
            </td>
            <td align="left">
              <asp:TextBox ID="txtPass" runat="server" Width="400px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="Chưa nhập mật khẩu" ForeColor="Red" 
                    ControlToValidate="txtPass"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
           <td colspan="2" align="center">
             <asp:Button ID="btnSend" runat="server"  Text="Gửi" Width="100px" Height="40px" 
                   onclick="btnSend_Click"/>
           </td>
         </tr>
      </table>
  </asp:View>
  <asp:View  ID="view2" runat="server">
     <table style=" width:100%;">
        <tr>
           <td align="center">
              <h2 style=" color:Red;">Gửi thành công ban quan trị sẽ cố gắng trả lời bạn trong thời gian sớm nhất</h2>
           </td>
        </tr>
     </table>
  </asp:View>
  <asp:View  ID="view3" runat="server">
     <table style=" width:100%;">
        <tr>
           <td align="center">
              <h2 style=" color:Red;">Thất bại! Kiểm tra Email và mật khẩu của bạn</h2>
           </td>
        </tr>
     </table>
  </asp:View>
</asp:MultiView>
</asp:Content>

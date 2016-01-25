<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="QuenMatKhau.aspx.cs" Inherits="WebBanDT.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:MultiView ID="multiview1" runat="server" >
   <asp:View ID="view1" runat="server">
      <table style="  width:100%;">
   <tr>
     <td align="center">
       <h2 style=" color: Red;">Lấy lại mật khẩu</h2>
     </td>
   </tr>
   <tr>
       <td style=" padding-left:140px;" align="center">
            Nhập Email: <asp:TextBox ID="txt_Email1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ErrorMessage="Không đúng định dạng" ControlToValidate="txt_Email1" 
                ForeColor="Red" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
       </td>
   </tr>
   <tr>
     <td style=" padding-left:70px;" align="center">
          <asp:Button ID="btb_GetPass" runat="server"  Text="Lấy mật khẩu" Height="25px" 
              onclick="btb_GetPass_Click"/>
     </td>
   </tr>
   <tr>
      <td style=" padding-left:50px;" align="center">
      
          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
              ControlToValidate="txt_Email1" ErrorMessage="Chưa nhập Email" ForeColor="Red"></asp:RequiredFieldValidator>
      
      </td>
   </tr>
</table>
   </asp:View>

   <asp:View ID="view2" runat="server">
        <table style=" width:100%;">
            <tr>
              <td align="center">
                 <h2 style=" color:Red;">Thông báo từ ban quản trị</h2>
              </td>
            </tr>
            <tr>
              <td align="center">
                 <h4 style=" color:Blue;">Thành công! Hãy kiểm tra Email </h4>
              </td>
            </tr>
        </table>
   </asp:View>
   <asp:View ID="view3" runat="server">
     <table style=" width:100%;">
       <tr>
          <td align="center">
            <h3 style=" color:Red;">Thông báo</h3>
          </td>
       </tr>
       <tr>
          <td align="center">
             <h4 style=" color:Blue;">Email bạn nhập không đúng </h4>
          </td>
       </tr>
       <tr>
           <td align="center"><asp:LinkButton ID="lbtn" runat="server" Text="Nhập lại" 
                   onclick="lbtn_Click"></asp:LinkButton></td>
       </tr>
     </table>
   </asp:View>
</asp:MultiView>

</asp:Content>

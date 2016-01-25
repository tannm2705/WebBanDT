<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="GioiThieu.aspx.cs" Inherits="WebBanDT.GioiThieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style=" width:800px;" align="center">
  <tr style=" height:50px;">
     <td align="center">
      
        <h3>Giới thiệu website</h3> 
     </td>
  </tr>
  <tr>
     <td align="center" style="border: 1px dotted #0000FF">
        <p style=" color:Red; font-size="medium">
            **
          Website 
         <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="~/TrangChu.aspx">www.Didongonline.com</asp:HyperLink>
         chính thức hoạt động tháng 05 năm 2014, cung cấp tất cả các sản phẩm<br /> 
         điện thoại từ cao cấp tới hàng phổ thông. Giá cả phải chăng đi kèm với các dịch vũ ưu đãi tốt nhất cho khách hàng<br />

        <br /> ** Lưu ý: Đặt hàng qua mạng được giảm giá 5% cho giá trị của sản phẩm ấy cửa hàng cam kết và đảm bảo uy<br /> tín
         trách nhiệm đối với khách hàng  hãy đến với chúng tôi để sở hữu những chú dế yêu mà bạn thích với giá rẻ nhất<br />
         và tưng bừng nhận quà khuyến mãi mùa hè cùng với các món quà cực kì hấp dẫn.
        </p>
     </td>
  </tr>
</table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="LienHe.aspx.cs" Inherits="WebBanDT.LienHe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<table align="center" style=" width:800px;">
   <tr style=" width:800px; height:50px;">
      <td align="center">
         <h3>Chi tiết liên hệ</h3>
      </td>
   </tr>
   <tr>
       <td align="center" style="border: 1px dotted #FF0000;">
          
          Siêu thị điện thoại di động online<br />
           <asp:HyperLink ID="HyperLink1" runat="server" Text="www.Didongonline.com"
               ForeColor="#0033CC" NavigateUrl="~/TrangChu.aspx"></asp:HyperLink> <br />
          Thành Phố Hà Nội<br />
          ĐT: 0932.060.886<br />
          Email: tannm2705@gmail.com
          
       </td>
   </tr>
   <tr>
       <td align="center" style="border: 1px dotted #FF0000;">
          <h3>Hướng dẫn mua hàng qua mạng</h3>
          <p style=" color:Red;" align="center">
              - Bước 1: Đăng nhập vào trang web, tìm kiếm sản phẩm và ấn vào nút "Đặt mua"<br />
              - Bước 2: Kiểm tra "Giỏ Hàng"<br />
              - Bước 3: Khi đã đồng ý mua thì ấn vào "Đặt hàng"<br />
              - Bước 4: Ấn vào "Xác Nhận Thanh Toán" khi đã đồng ý thanh toán<br />
              - Bước 5: Ấn vào nút thanh toán thông qua 
              <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="Blue" NavigateUrl="https://www.nganluong.vn/">Ngân Lượng </asp:HyperLink> 
              và làm theo hướng dẫn</p>
           <p style=" color:Red;" align="center">
               <br />
              Hàng sẽ được chuyển theo đường bưu điện chậm nhất 3 ngày!
            </p>
       </td>
   </tr>
</table>
</asp:Content>

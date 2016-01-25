<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ThemSanPham.aspx.cs" Inherits="WebBanDT.Admin.ThemSanPham1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 422px;
        }
        .style2
        {
            height: 37px;
        }
        .style3
        {
            width: 500px;
            height: 37px;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            height: 33px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="wapper">
        <table border="0" cellpadding="1" cellspacing="1" style=" width:100%; height:100%; float:left">
        <tr>
            <td align="right" class="style2">
                   <asp:Label ID="LbTenSanPham"  Text="Tên sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left" class="style3">
                   <asp:TextBox ID="txtTenSanPham" runat="server" Width="200px" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="right" class="style1">
                    <asp:Label ID="LbMaNSX"  Text="Nhà sản xuất" runat="server"></asp:Label>
            </td>
            <td align="left">
                    <asp:DropDownList ID="DropdownMaNSX" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="right" class="style1">
                   <asp:Label ID="LbMaKieuDang"  Text="Kiểu dáng" runat="server"></asp:Label>
            </td>
            <td align="left">
                   <asp:DropDownList ID="DropdownMaKieuDang" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr style=" height:40px;"> 
            <td align="right" class="style1">
                     <asp:Label ID="lbMaPhongCach"  Text="Phong cách" runat="server"></asp:Label>
            </td>
            <td align="left">
                     <asp:DropDownList ID="DropdownPhongCach" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr style=" height:100px;">
            <td align="right" class="style1">
                    <table class="style4" width="100%" height="100%" align="right">
                        <tr>
                            <td align="right">
                    <asp:Label ID="LbMoTaSanPham"  Text="Mô tả sản phẩm" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="style5">
                                Hệ Điều Hành</td>
                        </tr>
                        <tr>
                            <td align="right">
                                RAM</td>
                        </tr>
                        <tr>
                            <td align="right">
                                Camera</td>
                        </tr>
                        <tr>
                            <td align="right">
                                Pin</td>
                        </tr>
                    </table>
            </td>
            <td align="left">
                     <table class="style4" width="100%" height="100%">
                         <tr>
                             <td>
                     <asp:TextBox ID="txtMoTaSanPham" runat="server" Width="250px"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:DropDownList ID="DropDownList1" runat="server" 
                                     DataSourceID="SqlDataSource1" DataTextField="TenHDH" DataValueField="TenHDH">
                                 </asp:DropDownList>
                                 <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                     ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" 
                                     SelectCommand="SELECT DISTINCT [TenHDH] FROM [ThongTinSanPham]">
                                 </asp:SqlDataSource>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:TextBox ID="txtRAM" runat="server"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:TextBox ID="txtCamera" runat="server"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:TextBox ID="txtPin" runat="server"></asp:TextBox>
                             </td>
                         </tr>
                     </table>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="right" class="style1">
                    <asp:Label ID="LbImageSP"  Text="Hình sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="right" class="style1">
                     <asp:Label ID="LbGiaSanPham"  Text="Giá sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left">
                    <asp:TextBox ID="txtGiaSanPham" runat="server" Width="200px" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="right" class="style1">
                     <asp:Label ID="Label1"  Text="Số Lượng" runat="server"></asp:Label>
            </td>
            <td align="left">
                    <asp:TextBox ID="txtSoLuong" runat="server" Width="200px" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="center" colspan="2">
              
               <asp:Button ID="btnThem" runat="server" Text="Thêm sản phẩm"  Height="32px" 
                    onclick="btnThem_Click"/>
               <asp:Button ID="btnHuybo" runat="server" Text="Hủy bỏ"  Height="32px" 
                    onclick="btnHuybo_Click"/>
            </td>
        </tr>
          <tr style=" height:40px;">
              <td align="left" class="style1">
              <asp:Label ID="lbThongbao" runat="server"></asp:Label>
              </td>
        </tr>
    </table>
</div>
</asp:Content>

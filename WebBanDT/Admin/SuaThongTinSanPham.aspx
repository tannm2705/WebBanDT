<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SuaThongTinSanPham.aspx.cs" Inherits="WebBanDT.Admin.SuaThongTinSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 396px;
            height: 21px;
        }
        .style3
        {
            height: 21px;
        }
        .style7
        {
            height: 28px;
        }
        .style8
        {
            width: 396px;
            height: 43px;
        }
        .style9
        {
            height: 43px;
        }
        .style10
        {
            width: 396px;
            height: 12px;
        }
        .style11
        {
            height: 12px;
        }
        .style12
        {
            width: 396px;
            height: 8px;
        }
        .style13
        {
            height: 8px;
        }
        .style14
        {
            width: 396px;
            height: 10px;
        }
        .style15
        {
            height: 10px;
        }
        .style16
        {
            height: 7px;
        }
        .style17
        {
            width: 396px;
            height: 129px;
        }
        .style18
        {
            height: 129px;
        }
        .style19
        {
            width: 396px;
            height: 17px;
        }
        .style20
        {
            height: 17px;
        }
        .style21
        {
            height: 14px;
        }
        .style22
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="wapper">
        <table border="0" cellpadding="1" cellspacing="1" style=" width:100%; height:100%; float:left">
        <tr>
             <td align="center" colspan="2" class="style16">
                Sửa thông tin sản phẩm
            </td>
        </tr>
        <tr>
            <td align="right" class="style2">
                   <asp:Label ID="LbTenSanPham"  Text="Tên sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left" class="style3">
                   
                <asp:TextBox ID="txtTenSanPham" runat="server"></asp:TextBox>
                   
            </td>
        </tr>
        <tr>
            <td align="right" class="style10" >
                    <asp:Label ID="LbMaNSX"  Text="Nhà sản xuất" runat="server"></asp:Label>
            </td>
            <td align="left" class="style11">
                    <asp:DropDownList ID="DropdownMaNSX" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style12" >
                   <asp:Label ID="LbMaKieuDang"  Text="Kiểu dáng" runat="server"></asp:Label>
            </td>
            <td align="left" class="style13">
                   <asp:DropDownList ID="DropdownMaKieuDang" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr> 
            <td align="right" class="style14">
                     <asp:Label ID="lbMaPhongCach"  Text="Phong cách" runat="server"></asp:Label>
            </td>
            <td align="left" class="style15">
                     <asp:DropDownList ID="DropdownPhongCach" runat="server" Width="120px"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td align="right" class="style8">
                    <table class="style22" width="100%" height="100%" align="left">
                        <tr>
                            <td align="right">
                    <asp:Label ID="LbMoTaSanPham"  Text="Mô tả sản phẩm" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
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
            <td align="left" class="style9">
                     <table class="style22" width="100%" height="100%">
                         <tr>
                             <td>
                     <asp:TextBox ID="txtMoTaSanPham" runat="server" Width="350px" 
                         Font-Names="Times New Roman"></asp:TextBox>
                             </td>
                         </tr>
                         <tr>
                             <td>
                                 <asp:TextBox ID="txtHDH" runat="server"></asp:TextBox>
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
        <tr>
            <td align="right" class="style19" >
                    <asp:Label ID="LbGiaSanPham"  Text="Giá sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left" class="style20">
                    
                    <asp:TextBox ID="txtGiaSanPham" runat="server" Width="200px" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style19" >
                    <asp:Label ID="Label2"  Text="Số Lượng" runat="server"></asp:Label>
            </td>
            <td align="left" class="style20">
                    
                    <asp:TextBox ID="txtSoLuong" runat="server" Width="200px" Height="25px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="style17">
                     
                     <asp:Label ID="LbImageSP"  Text="Hình sản phẩm" runat="server"></asp:Label>
            </td>
            <td align="left" class="style18">
               <table>
                  <tr>
                      <td>
                          <asp:Image ID="image1" runat="server" Width="120px" Height="120px" />
                      </td>
                  </tr>
                  <tr>
                      <td class="style21">
                            <asp:FileUpload ID="FileUpload1" runat="server" />
                      </td>
                  </tr>
               </table>    
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr style=" height:40px;">
            <td align="center" colspan="2">
              
               <asp:Button ID="btnThem" runat="server" Text="Cập nhật"  Height="32px" 
                    onclick="btnCapNhat_Click"/>
               <asp:Button ID="btnXoa" runat="server" Text="Xóa SP"  Height="32px" 
                    onclick="btnXoa_Click"/>
               <asp:Button ID="btnHuybo" runat="server" Text="Hủy bỏ"  Height="32px" 
                    onclick="btnHuybo_Click"/>
            </td>
        </tr>
         <tr>
             <td align="center" colspan="2" class="style7">
                <asp:Label ID="lbThongbao" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</div>
</asp:Content>

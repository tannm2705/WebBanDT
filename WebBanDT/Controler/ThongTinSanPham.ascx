<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ThongTinSanPham.ascx.cs" Inherits="WebBanDT.Controler.ThongTinSanPham" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 105px;
    }
    .style2
    {
        height: 23px;
    }
</style>
<asp:DataList ID="datalist1" runat="server" RepeatColumns="1" Width="100%" Height="500px"
    ShowFooter="False" ShowHeader="False">
        <ItemTemplate>
        <center >
            <table style="border-style: dotted; border-width: 1px; border-color: #FF0000; width:100%" align="center">
                <tr>
                   <td align="center">
                       <asp:Label ID="tb" runat="server" Text="Thông tin chi tiết sản phẩm" Font-Size="Larger" ForeColor="Red"></asp:Label>
                   </td>
                </tr>
                <tr >
                    <td align="center" 
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted">
                        <asp:Image ID="Image1" runat="server" BorderColor="#FF8000" BorderStyle="Solid" 
                            BorderWidth="0px" ImageUrl='<%# Eval("ImageSP","{0}") %>' 
                            style="width: 200px; height: 200px" />
                    </td>
                </tr>
                <tr>
                    <td align="center" 
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted" >
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# Eval("MaSanPham","~/ThemGioHang.aspx?MaSanPham={0}") %>' 
                            Text='Đặt mua'></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td align="center" 
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted">
                        Số Lượng:<asp:Label ID="Label1" runat="server" ForeColor="Green" Text='<%# Eval("SoLuong","{0}") %>'></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td align="center" 
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted">
                        Giá:<asp:Label ID="Label2" runat="server" ForeColor="Green" Text='<%# Eval("GiaSanPham","{0:0,0} VND") %>'></asp:Label>
                        </td>
                </tr>
                <tr>
                   <td align="center" 
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted">
                    Mô tả
                   </td>
                </tr>
                <tr>
                   <td align="center" 
                        
                        
                        style="border-color: #FF0000; border-width: 1px; border-style: dotted; height:100%;">
                       <table class="style1">
                           <tr>
                               <td align="right" width="50%">
                                   Hệ Điều Hành:&nbsp;&nbsp;&nbsp; </td>
                               <td align="left" width="50%">
                                   <asp:Label ID="Label3" runat="server" ForeColor="Green" 
                                       Text='<%# Eval("TenHDH") %>'></asp:Label>
                               </td>
                           </tr>
                           <tr>
                               <td align="right" class="style2">
                                   RAM:&nbsp;&nbsp;&nbsp; </td>
                               <td align="left" class="style2">
                                   <asp:Label ID="Label4" runat="server" ForeColor="Green" 
                                       Text='<%# Eval("RAM") %>'></asp:Label>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   Camera:&nbsp;&nbsp;&nbsp; </td>
                               <td align="left">
                                   <asp:Label ID="Label5" runat="server" ForeColor="Green" 
                                       Text='<%# Eval("Camera") %>'></asp:Label>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   Pin:&nbsp;&nbsp;&nbsp; </td>
                               <td align="left">
                                   <asp:Label ID="Label6" runat="server" ForeColor="Green" 
                                       Text='<%# Eval("Pin", "{0} mAh") %>'></asp:Label>
                               </td>
                           </tr>
                           <tr>
                               <td align="right">
                                   Mô tả:&nbsp;&nbsp;&nbsp; </td>
                               <td align="left">
                                   <asp:Label ID="Label7" runat="server" ForeColor="Green" 
                                       Text='<%# Eval("MoTa") %>'></asp:Label>
                               </td>
                           </tr>
                       </table>
                   </td>
               </tr>
            </table>
            </center>
        </ItemTemplate>
        <HeaderStyle BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" />
    </asp:DataList>    
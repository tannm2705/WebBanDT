<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SanPhamBanChay.ascx.cs" Inherits="WebBanDT.Controls.Hienthitinraovat" %>
<style type="text/css">
    .style1
    {
       width:200px;
    }
    .style2
    {
        width: 100%;
    }
</style>

     <marquee direction="up" scrollamount="2" scrolldelay="40" scrollamount="1" truespeed="truespeed" onmouseover="this.stop()" onmouseout="this.start()" style=" height:550px; text-align: cente">
     <table style=" width:100%; height:100%;">
     <tr>
        <td align="center">
            <asp:DataList ID="datalist1" runat="server">
              <ItemTemplate>
                <table class="style2">
                    <tr align="center">
                             <td align="center">
                                <asp:Image ID="Image1" runat="server"  Width="110px" Height="110px" 
                                  ImageUrl='<%# Eval("ImageSP","{0}") %>'/>
                            </td>
                    </tr>
                    <tr>
                      <td align="center">
                         <asp:Label ID="lnTenSP" runat="server" ForeColor="Red" Text='<%# Bind("TenSanPham") %>'></asp:Label>
                      </td>
                    </tr>
                    <tr>
                        <td align="center">
                            Giá:<asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl='<%# Eval("MaSanPham","~/ChiTietSanPham.aspx?MaSanPham={0}") %>' 
                                Text='<%# Eval("GiaSanPham","{0}VNĐ") %>'></asp:HyperLink>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
           </asp:DataList>
        </td>
     </tr>
   </table>
        </marquee>


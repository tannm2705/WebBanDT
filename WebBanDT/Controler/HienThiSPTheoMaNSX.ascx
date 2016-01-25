<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiSPTheoMaNSX.ascx.cs" Inherits="WebBanDT.Controler.HienThiSPTheoMaNSX" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<style type="text/css">
    .style1
    {
        width: 200px;
    }
    .style2
    {
        
    }
    .style2 a
    {
        text-decoration:none;
        color:Blue;
    }
    .style2 a:hover
    {
        font-weight:bold;
        color:Red;
    }
</style>
<div class="style2">
<asp:DataList ID="datalist1" runat="server" RepeatColumns="4" Width="300px" 
    ShowFooter="False" ShowHeader="False">
        <ItemTemplate>
        <center style=" text-align: center">
            <table style="border-style: dotted; border-width: 1px; border-color: #FF0000; width: 202px">
                <tr >
                    <td align="center">
                        <asp:Image ID="Image1" runat="server" BorderColor="#FF8000" BorderStyle="Solid" 
                            BorderWidth="0px" ImageUrl='<%# Eval("ImageSP","{0}") %>' 
                            style="width: 80px; height: 90px" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# Eval("MaSanPham","~/ChiTietSanPham.aspx?MaSanPham={0}") %>' 
                            Text='<%# Eval("TenSanPham") %>'></asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        Giá:<asp:Label ID="Label2" runat="server" ForeColor="Green" Text='<%# Eval("GiaSanPham","{0:0,0} VND") %>'></asp:Label>
                        </td>
                </tr>
            </table>
            </center>
        </ItemTemplate>
        <HeaderStyle BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" />
    </asp:DataList>
    <cc1:CollectionPager ID="CollectionPager1" runat="server" BackText="« Trước" 
                    FirstText="Đầu" LabelText="Trang:" LastText="Cuối" NextText="Sau »" 
                    ResultsFormat="" ShowFirstLast="True" 
                    SliderSize="10" PagingMode="PostBack" BackNextDisplay="Buttons" 
                    BackNextLinkSeparator="•" HideOnSinglePage="True" IgnoreQueryString="False" 
                    PageNumbersDisplay="Numbers" PageSize="10" ResultsLocation="Top" 
                    SectionPadding="10" ShowLabel="True" ShowPageNumbers="True" UseSlider="True" 
                    BackNextLocation="Split" LabelStyle="" ControlStyle="color:red" 
                    PageNumbersStyle="color:RED" PageNumberStyle="">
             </cc1:CollectionPager>
</div>
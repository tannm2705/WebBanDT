<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebBanDT.Admin.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wapper1">
     <table style=" width:100%; height:100%;">
            <tr>
                 <td align="center">  
                     <p style=" color:Red;"> Danh sách các sản phẩm hiện có <br />Nhấn vào tên sản phẩm để sửa thông tin</p>
                 </td>
            </tr>
            <tr>
              <td align="center">
                  <asp:Button ID="ThemSP" runat="server" Text="Thêm Sản Phẩm" Height="30px" 
                      Width="115px" onclick="ThemSP_Click" />
              </td>
            </tr>
            <tr align="center"> 
                <td align="center">
                    <%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<style type="text/css">
    .style1
    {
        width: 200px;
    }
    .style2
    {
        height: 36px;
        width: 200px;
    }
</style>
<div class="link">
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
                            NavigateUrl='<%# Eval("MaSanPham","~/Admin/SuaThongTinSanPham.aspx?MaSanPham={0}") %>' 
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
                </td>
            </tr>
     </table>
</div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebBanDT.Search" %>
<%@ Register TagPrefix="cc1" Namespace="SiteUtils" Assembly="CollectionPager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleSheet2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

<table>
   <tr>
      <td>
        <div class="Search1">
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
        </div>
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
             
      </td>
   </tr>
</table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="WebBanDT.ChiTietSanPham1" %>
<%@ Register src="Controler/ThongTinSanPham.ascx" tagname="ThongTinSanPham" tagprefix="uc1" %>
<%@ Register Src="~/Controler/UserCmt.ascx" TagName="UserComment" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleSheet2.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style=" width:100%; height:500px;">
    <tr>
        <td align="center">
        <div id="chitietsp">
            <uc1:ThongTinSanPham ID="ThongTinSanPham1" runat="server" />
            <uc2:UserComment ID="UserComment" runat="server" />
        </div>
        </td>
    </tr>
</table>
</asp:Content>

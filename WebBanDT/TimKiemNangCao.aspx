<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="TimKiemNangCao.aspx.cs" Inherits="WebBanDT.TimKiemNangCao" %>
<%@ Register src="Controler/HienThiAllSP.ascx" tagname="HienThiAllSP" tagprefix="uc1" %>
<%@ Register src="Controler/HienThiSanPham.ascx" tagname="HienThiSanPham" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleSheet2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <uc2:HienThiSanPham ID="HienThiSanPham1" runat="server" />
</asp:Content>

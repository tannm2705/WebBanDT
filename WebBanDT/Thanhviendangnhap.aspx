<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="Thanhviendangnhap.aspx.cs" Inherits="WebBanDT.Thanhviendangnhap" %>
<%@ Register src="Controler/DangNhap.ascx" tagname="DangNhap" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table align="center" class="style1" style="width: 501px; margin-left: 85px">
        <tr>
            <td>
                <uc1:DangNhap ID="DangNhap1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="SanPham.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebBanDT.Web.SanPham1" %>
<%@ Register src="Controler/HienThiAllSP.ascx" tagname="HienThiAllSP" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/StyleSheet2.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
       <table style=" width:100%" align="center" >
           <tr>
                 <td align="center">
                     <asp:Label ID="LBHT" runat="server" Text="Các sản phẩm hiện có"  Font-Size="Larger" ForeColor="Red"></asp:Label>
                 </td>
           </tr>
           <tr align="center">
                <td align="center">
                <div id="HienThiSanPham">
                    <uc1:HienThiAllSP ID="HienThiAllSP1" runat="server" />
                </div>
                </td>
           </tr>
        </table>
</asp:Content>


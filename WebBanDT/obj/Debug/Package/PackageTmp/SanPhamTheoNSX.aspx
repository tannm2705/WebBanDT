<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="SanPhamTheoNSX.aspx.cs" Inherits="WebBanDT.ChiTietSanPham" %>
<%@ Register src="Controler/HienThiSPTheoMaNSX.ascx" tagname="HienThiSPTheoMaNSX" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table style=" width:100%;" align="center">
  <tr>
      <td>
           
          <uc1:HienThiSPTheoMaNSX ID="HienThiSPTheoMaNSX1" runat="server" />
           
      </td>
  </tr>
</table>
</asp:Content>


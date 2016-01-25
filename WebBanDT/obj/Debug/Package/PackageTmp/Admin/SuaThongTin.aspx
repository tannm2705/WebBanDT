<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SuaThongTin.aspx.cs" Inherits="WebBanDT.Admin.SuaThongTin" %>
<%@ Register src="../Controler/GridViewXoaSua.ascx" tagname="GridViewXoaSua" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="dangnhap" >
            <div style=" height:67px;">
                  <h2 style=" padding-top:15px; padding-left:100px; height:30px; color:Blue;">Quản lý tài khoản và người dùng</h2>
            </div>
            <div style=" width:100%; height:173px; margin-top:20px;"> 
              <marquee direction="left" scrollamount="2" scrolldelay="30" scrollamount="1" truespeed="truespeed" onmouseover="this.stop()" onmouseout="this.start()" style="text-align: center">
                Quản lý hệ thống 
                <br />
                Nâng cấp tài khoản lên quản trị
                <br />
                Xóa tài khoản người dùng
              </marquee> 
            </div>
    </div>
    <div id="dieukhien">
           <div style="margin-top:20px;">
          <marquee direction="left" scrollamount="2" scrolldelay="30" scrollamount="1" truespeed="truespeed" onmouseover="this.stop()" onmouseout="this.start()" style="text-align: center">
           Đăng nhập vào hệ thống
         </marquee> 
           </div>
           <div style=" margin:10px;"><asp:Label ID="labelThongbao" runat="server" ForeColor="Green"></asp:Label></div>
    </div>
    <div id="list">        
    <table style=" height:248px; width:960px; float:left;">
    <tr>
      <td align="center">
       <asp:Label ID="Thongtin" runat="server" Text="Thông tin người dùng" ForeColor="Red" Font-Size="XX-Large"></asp:Label>
      </td>
    </tr>
    <tr style=" width:960px; height:248px;">
    <td align="center">
        <uc1:GridViewXoaSua ID="GridViewXoaSua1" runat="server" />
    </td>
    </tr>
    </table> 
        
    </div>
    </div>
</asp:Content>

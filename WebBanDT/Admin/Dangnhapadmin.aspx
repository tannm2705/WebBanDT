<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Dangnhapadmin.aspx.cs" Inherits="WebBanDT.Admin.Dangnhapadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="dangnhap" >
            <div style=" height:50px;">
                  <h2 style=" padding-top:15px; padding-left:100px; height:30px; color:Blue;">Nhập thông tin tài khoản</h2>
            </div>
            <div style=" height:50px; width:477px;">
                  <div style=" margin-left:80px; margin-top:10px; width:90px; height:30px; float:left">
                      <h3 style=" color:Maroon; height:30px; width: 100px;">Tài Khoản:</h3></div>
                  <div style=" margin-left:10px; margin-top:15px; width:200px; float:left"><asp:TextBox ID="txtEmail" runat="server" Width="200px" Height="30px"></asp:TextBox></div>
            </div>
            <div style=" height:50px; width:477px;">
                  <div style=" margin-left:80px; margin-top:10px; width:90px; height:30px; float:left"><h3 style=" color:Maroon; height:30px;">Mật khẩu:</h3></div>
                  <div style=" margin-left:10px; margin-top:15px; width:200px; float:left">
                      <asp:TextBox ID="txtPass" runat="server" Width="200px" Height="30px" 
                          TextMode="Password"></asp:TextBox></div>
            </div>
            <div style=" height:80px; width:477px;">
                  <div style=" width:100px; height:35px; margin-left:100px; margin-top:20px; float:left">
                    <asp:Button ID="btnDangNhap" runat="server"  Text="Đăng Nhập" Width="100px" Height="35px" OnClick="DangNhap_Click"/>
                  </div>
                  <div style=" width:100px; height:35px; margin-left:30px; margin-top:20px; float:left">
                    <asp:Button ID="btnDangXuat" runat="server"  Text="Đăng xuất" Width="100px" Height="35px" OnClick="DangXuat_Click"/>
                  </div>
                  <div style=" width:100px; height:35px; margin-left:30px; margin-top:20px; float:left">
                    <asp:Button ID="btnHuyBo" runat="server"  Text="Hủy Bỏ" Width="100px" Height="35px" OnClick="HuyBo_Click"/>
                  </div>
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
    <div style="height:50px; width:960px;">
       <!--<h2 style=" padding-left:200px; padding-top:10px; width:660px; height:40px;">Danh sách quản trị viên và người dùng trong hệ thống</h2>-->
    </div>
    <div style=" height: 250px; width:960px;">
    <table style=" height:248px; width:960px; float:left;">
    <tr style=" width:960px; height:248px;">
    <td align="center">
    </td>
    </tr>
    </table> 
    </div>
    </div>
</asp:Content>

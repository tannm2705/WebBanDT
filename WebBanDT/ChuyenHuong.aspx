<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChuyenHuong.aspx.cs" Inherits="WebBanDT.ChuyenHuong" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
<!--
        function Redirect() {
            window.location = "SanPham.aspx";
        }
        setTimeout('Redirect()', 5000);
//-->
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
       <table style=" width:960px; height:230px;" align="center">
          <tr style=" width:100%; height:30px;">
             <td align="left" style=" width:100%; height:25px; background-color:Green;">
                <asp:Label ID="lb1" Text="Đang chuyển hướng..........." ForeColor="White" runat="server"></asp:Label>
             </td>
          </tr>
          <tr style="width:100%; height:200px;">
            <td align="center" style=" height:70px; width:960px; background-color:Black;" 
                  valign="top">
                <div style=" width:100%; height:50px; padding-top:25px;">
                   <asp:Label ID="lb2" runat="server" Text="Chào mừng:" ForeColor="Yellow"></asp:Label>
                   <asp:Label ID="LbTen" runat="server" ForeColor="Yellow"></asp:Label>
                   <asp:Label ID="Lb3" runat="server" Text=" đã quay trở lại website." ForeColor="Yellow"></asp:Label>
                </div>
                <div>
                     <embed height="70px" pluginspage="http://www.macromedia.com/go/getflashplayer" quality="high"
                     src="images/Loading3.swf" type="application/x-shockwave-flash" width="70px">
                     </embed>
                </div>
                <div style=" width:100%; height:50px; padding-top:20px;">
                   <asp:HyperLink ID="hplk1" runat="server" Text="Bấm vào đây nếu bạn cảm thấy đợi lâu." ForeColor="Green" NavigateUrl="~/SanPham.aspx"></asp:HyperLink>
                </div>
            </td>
          </tr>
      </table>
    </div>
    </form>
</body>
</html>

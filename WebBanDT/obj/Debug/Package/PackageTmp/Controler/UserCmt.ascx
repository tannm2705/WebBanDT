<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserCmt.ascx.cs" Inherits="WebBanDT.Controler.UserCmt" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>
<%@ Register assembly="CollectionPager" namespace="SiteUtils" tagprefix="cc1" %>
<style type="text/css">
    .style3
    {
        width: 57%;
        height: 200px;
    }
    .style4
    {
        width: 50%;
        height: 200px;
    }
            .style5
    {
        width: 100%;
    }
            .style6
    {
        width: 100px;
    }
            .style7
    {
        width: 30%;
    }
            .style8
    {
        width: 100%;
    }
    
                .ratingEmpty
            {
            background-image: url(RatingStar/ratingStarEmpty.gif);
            width:18px;
            height:18px;
            }
            .ratingFilled
            {
            background-image: url(RatingStar/ratingStarFilled.gif);
            width:18px;
            height:18px;
            }
            .ratingSaved
            {
             background-image: url(RatingStar/ratingStarSaved.gif);
            width:18px;
            height:18px;
            }
            </style>

<link href="../CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />

<table class="style8" align="center">
    <tr>
    <td width="30%" align="center">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:Button ID="btFollow" runat="server" Font-Bold="True" ForeColor="Blue" 
           onclick="btFollow_Click" Text="Theo Dõi Sản Phẩm" />
    </td>
        <td width="20%" align="right"><b style="color: #000000">Điểm Trung Bình: </b></td>
        <td width="50%">
            <ajax:Rating ID="ratingControl" runat="server" AutoPostBack="True" OnChanged="RatingControlChanged"
                StarCssClass="ratingEmpty" WaitingStarCssClass="ratingSaved" 
                EmptyStarCssClass="ratingEmpty" FilledStarCssClass="ratingFilled">
            </ajax:Rating>
           <b style="color: #000000"> <asp:label ID="lbltxt" runat="server" 
                Font-Bold="True" ForeColor="#000099"/></b>
        </td>
    </tr>
</table>
<asp:Label ID="lbEmail" runat="server" Visible="False"></asp:Label>
<asp:DataList ID="dlThongTinCmt" runat="server" BackColor="White" 
    BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
    ForeColor="Black" 
    GridLines="Vertical" Width="100%">
    <AlternatingItemStyle BackColor="#CCCCCC" />
    <FooterStyle BackColor="#CCCCCC" />
    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    <ItemTemplate>
        <table class="style5" rules="all" frame="box">
            <tr>
                <td align="center" class="style6" style="border: thin groove #FF0000; background-color: #FFFF66">
                    <asp:Image ID="Image1" runat="server" Height="60px" 
                        ImageUrl='<%# Eval("ImgUrl") %>' Width="60px"/> <br />
                    <asp:Label ID="lbName" runat="server" ForeColor="Red" 
                        Text='<%# Eval("HoTen") %>'></asp:Label>
                </td>
                <td style="padding: inherit; border-style: groove double groove double; border-color: #008000; border-width: thin; vertical-align: top; background-color: #FFCC99;">
                    <asp:Label ID="lbComment" runat="server" Text='<%# Eval("Comment") %>'></asp:Label>
                </td>
            </tr>
        </table>
    </ItemTemplate>
    <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
</asp:DataList>
    <cc1:CollectionPager ID="CollectionPager1" 
    FirstText="Đầu" 
    BackText="« Trước &amp;nbsp;" 
    LabelText="" 
    LastText="Cuối" 
    NextText="&amp;nbsp; Sau  »" 
    ShowFirstLast="True" 
    SliderSize="5" PagingMode="PostBack"
    runat="server" BackNextLinkSeparator="" BackNextLocation="Split" 
    PageNumbersDisplay="Numbers" ResultsLocation="None" 
    BackNextDisplay="Buttons">
    </cc1:CollectionPager>
<table class="style3" align="left" style="border: medium outset #00FF00">
    <tr>
        <td style="vertical-align: top; background-color: #CCFF66;" align="left" 
            class="style4">
            <table class="style5">
                <tr>
                    <td height="180px" style="vertical-align: top; text-align: center" 
                        class="style7">
                    <br />
                  <asp:DataList ID="dlComment" runat="server">
                <ItemTemplate>
                   &nbsp&nbsp &nbsp<asp:Image ID="Image2" runat="server" Height="100px" 
                        ImageUrl='<%# Eval("ImgUrl") %>' Width="100px" />
                </ItemTemplate>
            </asp:DataList>
                        <asp:Label ID="lbHoTen" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                    </td>
                    <td width="70%" style="vertical-align: top">
                        <asp:Label ID="lblCmt" runat="server" Text="Bình Luận: "></asp:Label>
                        <br />
                        <asp:TextBox ID="txtCmt" runat="server" Height="110px" TextMode="MultiLine" 
                Width="300px"></asp:TextBox>
                        <br />
            <asp:Button ID="btnPost" runat="server" Height="30px" onclick="btnPost_Click" 
                Text="Bình luận" Width="70px" />
                    </td>
                </tr>
            </table>
</td>
    </tr>
</table>

&nbsp&nbsp&nbsp&nbsp&nbsp<asp:Label ID="LbThongbao" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red"></asp:Label>

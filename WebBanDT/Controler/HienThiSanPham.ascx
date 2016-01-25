<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HienThiSanPham.ascx.cs" Inherits="WebBanDT.Controler.HienThiSanPham" %>
<style type="text/css">

    .style1
    {
        width: 100%;
    }
    .style2
    {
        width: 160px;
    }
select{
width:180px;
}
</style>
    <table class="style1" style="border: thin ridge #00FF00; width: 820px;" 
    width="100%">
    <tr>
        <td class="style2" align="center" style="border: thin ridge #00FF00">
            <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Overline="False" 
                Font-Underline="False" Text="(*)Tìm Kiếm Theo Giá: "></asp:Label>
        </td>
        <td style="border: thin ridge #00FF00">
            <asp:Label ID="Label2" runat="server" Text="Từ: "></asp:Label>
&nbsp;<asp:DropDownList ID="ddFrom" runat="server" Width="125px">
                <asp:ListItem Value="0">---- Select ----</asp:ListItem>
                <asp:ListItem Value="200000">200.000 VND</asp:ListItem>
                <asp:ListItem Value="500000">500.000 VND</asp:ListItem>
                <asp:ListItem Value="1000000">1 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="2000000">2 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="3000000">3 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="4000000">4 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="5000000">5 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="6000000">6 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="7000000">7 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="8000000">8 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="9000000">9 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="10000000">10 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="15000000">15 Triệu VNĐ</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Đến:
            <asp:DropDownList ID="ddTo" runat="server" Width="125px">
                <asp:ListItem Value="0">---- Select ----</asp:ListItem>
                <asp:ListItem Value="200000">200.000 VND</asp:ListItem>
                <asp:ListItem Value="500000">500.000 VND</asp:ListItem>
                <asp:ListItem Value="1000000">1 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="2000000">2 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="3000000">3 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="4000000">4 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="5000000">5 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="6000000">6 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="7000000">7 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="8000000">8 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="9000000">9 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="10000000">10 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="15000000">15 Triệu VNĐ</asp:ListItem>
                <asp:ListItem Value="20000000">20 Triệu</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="style2" align="center" style="border: thin ridge #00FF00">
            <asp:Label ID="Label3" runat="server" Font-Bold="False" Text="Hãng Sản Xuất: "></asp:Label>
        </td>
        <td style="border: thin ridge #00FF00">
            <asp:DropDownList ID="ddHangSanXuat" runat="server" Width="160px" 
                DataSourceID="SqlDataSource1" DataTextField="TenNSX" DataValueField="MaNSX">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" 
                SelectCommand="SELECT * FROM [NhaSX] ORDER BY [MaNSX]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="style2" align="center" style="border: thin ridge #00FF00">
            <asp:Label ID="Label4" runat="server" Text="Tính năng: "></asp:Label>
        </td>
        <td style="border: thin ridge #00FF00">
            <asp:Label ID="Label5" runat="server" Text="Hệ Điều Hành: "></asp:Label>
          &nbsp&nbsp  <asp:DropDownList ID="ddHeDieuHanh" runat="server" 
                DataSourceID="SqlDataSource3" DataTextField="TenHDH" DataValueField="TenHDH">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" 
                ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" 
                SelectCommand="SELECT DISTINCT [TenHDH] FROM [ThongTinSanPham]">
            </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kiểu Dáng:
       &nbsp&nbsp     <asp:DropDownList ID="ddKieuDang" runat="server" 
                DataSourceID="SqlDataSource2" DataTextField="TenKieuDang" 
                DataValueField="MaKieuDang">
                <asp:ListItem>----Select----</asp:ListItem>
                <asp:ListItem Value="1">Cảm Ứng</asp:ListItem>
                <asp:ListItem Value="2">Đen Trắng</asp:ListItem>
                <asp:ListItem Value="3">Không Cảm Ứng</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" 
                SelectCommand="SELECT * FROM [KieuDang] ORDER BY [MaKieuDang]">
            </asp:SqlDataSource>
            <br />
            <br />
            Máy Ảnh:&nbsp;
         &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp   <asp:DropDownList ID="ddMayAnh" 
                runat="server" DataSourceID="SqlDataSource4" DataTextField="Camera" 
                DataValueField="Camera">
                <asp:ListItem Value="0">----Select----</asp:ListItem>
                <asp:ListItem Value="1">VGA</asp:ListItem>
                <asp:ListItem Value="2 MP">1 MP</asp:ListItem>
                <asp:ListItem Value="2 MP">2 MP</asp:ListItem>
                <asp:ListItem Value="3 MP">3 MP</asp:ListItem>
                <asp:ListItem>5 MP</asp:ListItem>
                <asp:ListItem>8 MP</asp:ListItem>
                <asp:ListItem>12 MP</asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" 
                ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" 
                SelectCommand="SELECT DISTINCT [Camera] FROM [ThongTinSanPham]">
            </asp:SqlDataSource>
        </td>
    </tr>
</table>
    <table class="style1">
        <tr>
            <td align="center" width="100%">
                <asp:Button ID="btnTimKiem" runat="server" Text="Search" 
                    onclick="btnTimKiem_Click" />
                <br />
                <br />
                <asp:Label ID="LbThongBao" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
    </table>
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

             



             


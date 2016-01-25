<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="FollowingProduct.aspx.cs" Inherits="WebBanDT.FollowingProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="view1" runat="server">
            <p align="center" style=" color:Red;">
        Bạn chưa đăng nhập! Hãy
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0033CC" 
            NavigateUrl="~/Thanhviendangnhap.aspx">Đăng nhập</asp:HyperLink>
        &nbsp;để sử dụng dịch vụ của chúng tôi.<br /> Nếu bạn chưa có tài khoản tiến hành:
                <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="Blue" 
            NavigateUrl="~/DangKy.aspx">Đăng ký</asp:HyperLink>
            </p>
        </asp:View>
        <asp:View ID="view2" runat="server">
            <h3 align="center">
                Sản Phẩm
                <asp:Label ID="lbHoTen" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
                &nbsp;Đang Quan Tâm</h3>
            <table class="style1">
                <tr>
                    <td width="100%">
                        <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" OnItemCommand="Item_Command"
                    RepeatDirection="Horizontal" Width="100%">
                            <ItemTemplate>
                                <table style="border-style: dotted; border-width: 1px; border-color: #FF0000; width: 202px">
                                    <tr>
                                        <td align="center">
                                            <asp:Image ID="Image1" runat="server" BorderColor="#FF8000" BorderStyle="Solid" 
                                        BorderWidth="0px" ImageUrl='<%# Eval("ImageSP","{0}") %>' 
                                        style="width: 80px; height: 90px" />
                                        </td>
                                    </tr>
                                       <tr>
                                        <td align="center">
                                       <asp:Label ID="lbMaSanPham" runat="server" 
                                        Text='<%# Eval("MaSanPham") %>' Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:HyperLink ID="HyperLink3" runat="server" 
                                        NavigateUrl='<%# Eval("MaSanPham","~/ChiTietSanPham.aspx?MaSanPham={0}") %>' 
                                        Text='<%# Eval("TenSanPham") %>'></asp:HyperLink>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" class="style2">
                                    Giá:<asp:Label ID="Label2" runat="server" ForeColor="Green" 
                                        Text='<%# Eval("GiaSanPham","{0} VND") %>'></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                    <td align="center" class="style2">
                                        <asp:Button ID="btninside" Text="Hủy Theo Dõi" CommandName="Select" runat="server"/>
                                    </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>

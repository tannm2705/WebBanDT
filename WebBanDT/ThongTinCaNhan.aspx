<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="ThongTinCaNhan.aspx.cs" Inherits="WebBanDT.ThongTinCaNhan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:MultiView ID="MultiView2" runat="server">
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
        <h3 align="center" style="height: 20px">Thông Tin Cá Nhân</h3>
            <table class="style1">
                <tr>
                    <td align="center" height="200px" width="30%" 
                        style="border-style: double; border-color: #00FF00" bgcolor="White">
                 <asp:DataList ID="dlIgmUser" runat="server">
                <ItemTemplate>
                    <asp:Image ID="Image2" runat="server" Height="200px" 
                        ImageUrl='<%# Eval("ImgUrl") %>' Width="200px" />
                </ItemTemplate>
            </asp:DataList>
                    </td>
                    <td style="vertical-align: top">
                        <table class="style1" style="border-style: groove; border-color: #00FF00">
                            <tr>
                                <td align="center" width="30%" style="border: thin groove #00FFFF;" bgcolor="White">
                                    Tên Tài Khoản: </td>
                                <td style="border: thin groove #00FFFF" bgcolor="White">
                                    <asp:Label ID="lbTenTK" runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" width="30%" style="border: thin groove #00FFFF" bgcolor="White">
                                    Họ Tên:</td>
                                <td style="border: thin groove #00FFFF" bgcolor="White">
                                    <asp:DataList ID="DataList1" runat="server">
                                        <ItemTemplate>
                                            <asp:Label ID="bHoTen" runat="server" ForeColor="Blue" 
                                                Text='<%# Eval("HoTen") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                    <asp:Button ID="btDoiTen" runat="server" Text=" Đổi Tên" 
                                        onclick="btDoiTen_Click" />
                                </td>
                            </tr>
                            <tr>
                            <td align="center" style="border: thin groove #00FFFF" width="30%" bgcolor="White">
                                Địa Chỉ:&nbsp;</td>
                            <td style="border: thin groove #00FFFF" bgcolor="White">
                                      <asp:DataList ID="dlDiaChi" runat="server">
                                        <ItemTemplate>
                                            <asp:Label ID="lbDiaChi" runat="server" ForeColor="Blue" 
                                                Text='<%# Eval("DiaChi") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                    <asp:Button ID="btDoiDiaChi" runat="server" Text="Thay Đổi" 
                                          onclick="btDoiDiaChi_Click" />
                                     &nbsp <asp:TextBox ID="txtDiaChi" runat="server" Visible="False" Width="120px"></asp:TextBox>
                                      &nbsp;<asp:Button ID="btDongY" runat="server" onclick="btDongY_Click" 
                                          Text="Xác Nhận" Visible="False" />
                                      <asp:Button ID="btHuy" runat="server" onclick="btHuy_Click" Text="Hủy" 
                                          Visible="False" />
                            </td>
                            </tr>
                            <tr>
                                <td align="center" width="30%" style="border: thin groove #00FFFF" bgcolor="White">
                                Số Điện Thoại</td>
                                <td style="border: thin groove #00FFFF" bgcolor="White">
                                    <asp:DataList ID="dlSoDT" runat="server">
                                        <ItemTemplate>
                                            <asp:Label ID="lbSoDT" runat="server" ForeColor="Blue" Text='<%# Eval("SoDT") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                    <asp:Button ID="btChangeSDT" runat="server" Text="Thay Đổi" OnClick="btChangeSDT_Click" />
                                    &nbsp;
                                    <asp:TextBox ID="txtSoDT" runat="server" Visible="False" Width="120px"></asp:TextBox>
                                    &nbsp;<asp:Button ID="btXacNhan" runat="server" Text="Xác Nhận" Visible="False" OnClick="btXacNhan_Click" />
                                    <asp:Button ID="btCancel" runat="server" Text="Hủy" Visible="False" OnClick="btCancel_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" width="30%" style="border: thin groove #00FFFF" bgcolor="White">
                                    Số Fax: 
                                </td>
                                <td style="border: thin groove #00FFFF" bgcolor="White">

                                    <asp:DataList ID="dlSoFax" runat="server">
                                        <ItemTemplate>
                                            <asp:Label ID="lbSoFax" runat="server" ForeColor="Blue" Text='<%# Eval("SoFax") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:DataList>
                                    <asp:Button ID="btChangeSoFax" runat="server" Text="Thay Đổi" OnClick="btChangeSoFax_Click" />
                                    &nbsp;
                                    <asp:TextBox ID="txtSoFax" runat="server" Visible="False" Width="120px"></asp:TextBox>
                                    &nbsp;<asp:Button ID="btXacNhanSoFax" runat="server" OnClick="btXacNhanSoFax_Click" Text="Xác Nhận" Visible="False" />
                                    <asp:Button ID="btCancelSoFax" runat="server" OnClick="btCancelSoFax_Click" Text="Hủy" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                            <td align="center" width="30%" style="border: thin groove #00FFFF" bgcolor="White">
                                Mật Khẩu:</td>
                            <td style="border: thin groove #00FFFF" bgcolor="White">
                                <asp:Button ID="btMatKhau" runat="server" Text="Đổi Mật Khẩu" 
                                    onclick="btMatKhau_Click" />
                            </td>
                            </tr>
                            <tr>
                            <td align="center" style="border: thin groove #00FFFF" width="30%" bgcolor="White">
                                Ảnh Đại Diện:&nbsp;</td>
                            <td style="border: thin groove #00FFFF" bgcolor="White">
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </td>
                            </tr>
                            <tr>
                            <td bgcolor="White"></td>
                            <td bgcolor="White">
                                <asp:Button ID="btUpDate" runat="server" Text="Cập Nhật Ảnh Đại Diện" 
                                    onclick="btUpDate_Click" />
                                &nbsp;
                                <asp:Label ID="lbThongBao1" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="view3" runat="server">

            <table class="style1" style="border-style: groove; border-color: #00FF00">
                <tr>
                    <td align="center" style="border: thin groove #00FFFF" width="30%">
                        Mật Khẩu Mới</td>
                    <td style="border: thin groove #00FFFF">
                        <asp:TextBox ID="txtMKNew1" runat="server" Width="80%" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" style="border: thin groove #00FFFF">
                        Nhập Lại Mật Khẩu Mới</td>
                    <td style="border: thin groove #00FFFF">
                        <asp:TextBox ID="txtMKNew2" runat="server" Width="80%" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lbError2" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td align="center">
                        <asp:Button ID="btXacNhanMK" runat="server" Text="Xác Nhận" 
                            onclick="btXacNhanMK_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                <td>
                </td>
                <td align="center">
                    <asp:Label ID="lbThongBao" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                </td>
                </tr>
            </table>
        </asp:View>
        <asp:View ID="view4" runat="server">

            <table class="style1" style="border-style: groove; border-color: #00FF00">
                <tr>
                    <td align="center" style="border: thin groove #00FFFF" width="30%">
                        Họ Tên Hiện Tại:</td>
                    <td style="border: thin groove #00FFFF" width="70%">
                        <asp:DataList ID="DataList2" runat="server">
                            <ItemTemplate>
                                <asp:Label ID="bHoTen0" runat="server" ForeColor="Red" 
                                    Text='<%# Eval("HoTen") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:DataList>
                    </td>
                </tr>
                <tr>
                    <td align="center" style="border: thin groove #00FFFF" width="30%">
                        Họ Tên Mới:</td>
                    <td style="border: thin groove #00FFFF">
                        <asp:TextBox ID="txtHoTenNew" runat="server" Width="40%"></asp:TextBox>
                        &nbsp;&nbsp;
                        <asp:Button ID="btXacNhanTen" runat="server" Text="Xác Nhận" 
                            onclick="btXacNhanTen_Click" />
                    </td>
                </tr>
            </table>

        </asp:View>
    </asp:MultiView>
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.ascx.cs" Inherits="WebBanDT.Controler.DangNhap" %>
																					 <asp:MultiView ID="multiview1" runat="server">
											<asp:View ID="view1" runat="server">
												<div id="Div16" class="login" runat="server" 
                                                    style="font-size: large; font-weight: bold; color: #FF0000;">
													  Tên đăng nhập:
												</div>
												<asp:TextBox ID="txtEmail" runat="server" CssClass="txtdangnhap" Width="200px"></asp:TextBox>
												<div id="Div2" class="login" runat="server" 
                                                    style="font-size: large; font-weight: bold; color: #FF0000">
													  Mật khẩu:
												</div>
												<asp:TextBox ID="txtMatKhau" runat="server" CssClass="txtdangnhap" 
													TextMode="Password" Width="200px"></asp:TextBox>
                                                    <br />
												<asp:Button ID="Button1" CssClass="buttomDangnhap" Text="Đăng Nhập" 
													runat="server" onclick="Button1_Click"/>
												<asp:CheckBox ID="checkbox1" runat="server" Text="Ghi nhớ" />
												<div id="dangky" runat="server">
													 <a href="DangKy.aspx">Đăng ký</a> | <a href="QuenMatKhau.aspx">Quên mật khẩu</a>
												</div>
                                                <div>
													 <asp:Label ID="lbThongBao" runat="server" Text=""></asp:Label>
												</div>
                                                <br />
                                                <div style="font-size: large; font-weight: bold; font-style: italic; text-decoration: underline; color: #FF0000">
                                                   *Chú ý:
                                                  <br /><ul> Ấn vào <a href="../Admin/Dangnhapadmin.aspx">đây</a> nếu bạn là Quản Trị Viên!   </ul>   
                                                </div>
											</asp:View>
										</asp:MultiView>
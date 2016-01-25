<%@ Page Title="" Language="C#" MasterPageFile="~/SanPham.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="WebBanDT.GioHang" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            height: 60px;
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
<asp:MultiView ID="multiview1" runat="server">
   <asp:View ID="view1" runat="server">
      <table style=" width:100%;" >
   <tr>
      <td align="center" style=" padding-top:20px;" class="style2">
          <asp:Label ID="lb" runat="server" Text="GIỎ HÀNG CỦA BẠN" Font-Size="X-Large" ForeColor="Red"> </asp:Label>
      </td>
   </tr>
   <tr>
      <td align="center">
        <table>
           <tr align="left">
              <td>
                Email:
              </td>
              <td>
                <asp:Label ID="lbEmail" runat="server"></asp:Label>
              </td>
           </tr>

           <tr align="left">
              <td>
                 Họ tên:
              </td>
              <td>
                 <asp:Label ID="lbHoTen" runat="server"></asp:Label>
              </td>
           </tr>

           <tr align="left">
              <td>
                 Ngày đặt:
              </td>
              <td>
                 <asp:Label ID="lbNgayDatHang" runat="server"></asp:Label>
              </td>
           </tr>

           <tr align="left">
                <td>
                 Ngày Chuyển: 
                </td>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                        <asp:TextBox ID="txtNgayChuyen" runat="server"></asp:TextBox>
                        &nbsp; <a>(mm/dd/yyyy)*</a>
                        <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtNgayChuyen" runat="server" />
                </td>
           </tr>

           <tr align="center">
              <td> 
                Địa chỉ nhận:
              </td>
              <td align="left">
                 <asp:TextBox ID="txtDiaChiNhan" runat="server" TextMode="MultiLine" Height="80px"></asp:TextBox>
              &nbsp;(*)</td>
           </tr>

           </table>
      </td>
   </tr>
   <tr>
      <td align="center" class="style1">
   <asp:GridView ID="grv_GioHang" runat="server"
          BackColor="White" BorderColor="Blue" BorderStyle="Dashed"
          AutoGenerateColumns="false"
          DataKeyNames="ID"
          OnPageIndexChanging="grv_PageChanging"
          OnRowCancelingEdit="grv_RowCancelingEdit"
          OnRowEditing="grv_RowEditing"
          OnRowDeleting="grv_RowDeleting"
          OnRowUpdating="grv_RowUpdating"
          ShowFooter="true"
          >
          <Columns>
             <asp:TemplateField HeaderText="Tên sản phẩm"><ItemTemplate><asp:Label ID="lbTenSanPham" runat="server" Text='<%# Bind("TenSanPham") %>' Width="150px"></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox ID="txtTenSanPham" runat="server" ReadOnly="true" Text='<%# Eval("TenSanPham") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField>
             <asp:TemplateField HeaderText="Giá tiền"><ItemTemplate><asp:Label ID="lbGiaTien" runat="server" Text='<%# Bind("GiaTien","{0:0,0} VND") %>' Width="150px"></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox ID="txtGiaTien" runat="server" Text='<%# Eval("GiaTien","{0:0,0} VND") %>' ReadOnly="true"></asp:TextBox></EditItemTemplate></asp:TemplateField>
             <asp:TemplateField HeaderText="Số lượng"><ItemTemplate><asp:Label ID="lbSoLuong" runat="server" Text='<%# Bind("SoLuong") %>' Width="150px"></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox ID="txtSoLuong" runat="server" Text='<%# Eval("SoLuong") %>'></asp:TextBox></EditItemTemplate></asp:TemplateField>
             <asp:TemplateField HeaderText="Tổng tiền"><ItemTemplate><asp:Label ID="lbTongTien" runat="server" Text='<%# Bind("TongTien","{0:0,0} VND") %>' Width="150px"></asp:Label></ItemTemplate><EditItemTemplate><asp:TextBox ID="txtTongTien" runat="server" Text='<%# Eval("TongTien","{0:0,0} VND") %>' ReadOnly="true"></asp:TextBox></EditItemTemplate></asp:TemplateField>
             <asp:TemplateField HeaderText="Sửa"><ItemTemplate><asp:ImageButton ID="imgbtn1" runat="server" ToolTip="Sửa" CommandName="Edit" ImageUrl="~/images/edit.png"/></ItemTemplate><EditItemTemplate><asp:ImageButton ID="imgbtn2" runat="server" ToolTip="Update" CommandName="Update" ImageUrl="~/images/Save.png" /><asp:ImageButton ID="imgbtn3" runat="server" ToolTip="Cancel" CommandName="Cancel" ImageUrl="~/images/back.png" /></EditItemTemplate></asp:TemplateField>
             <asp:TemplateField HeaderText="Xóa"><ItemTemplate><asp:ImageButton ID="imgbtn4" ToolTip="Delete" CommandName="Delete" runat="server" ImageUrl="~/images/Delete.png"/></ItemTemplate></asp:TemplateField>
          </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
          </asp:GridView>
      </td>
   </tr>
   <tr>
      <td align="center" class="style1">
         <asp:Button ID="btnThanhToan" runat="server" OnClick="Thanhtoan_Click" Text="Đặt hàng"  OnClientClick="return confirm('Hãy nhập đầy đủ thông tin trước khi Đặt hàng! Những trường có dấu (*) bắt buộc phải nhập')"/>
         <asp:Button ID="btnMuaThem" runat="server" OnClick="Muathem_Click"  Text="Mua thêm"/>
         <asp:Button ID="btnHuyGiohang" runat="server" OnClick="Huygiohang_Click" Text=" Hủy giỏ hàng" OnClientClick="return confirm('Bạn muốn xóa all')"/>
      </td>
   </tr>
   <tr>
      <td align="center" class="style1">
          <asp:Label ID="LbThongbao" runat="server" ForeColor="Blue"></asp:Label>
      </td>
   </tr>
   
</table>
   </asp:View>
   <asp:View ID="view2" runat="server">
      <table style=" width:100%;">
           <tr>
             <td><h3>Đặt hàng thành công</h3>
                 <p align="center" style="font-size: large; font-weight: bold; color: #FF0000">
                     Giỏ hàng của bạn</p>
                 <p align="center" style="text-align: center">
                     <asp:GridView ID="gvDonHang" runat="server" AutoGenerateColumns="False" 
                         BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" 
                         CellPadding="4" DataKeyNames="MaDonHang" DataSourceID="SqlDataSource1" 
                         onselectedindexchanged="gvDonHang_SelectedIndexChanged">
                         <Columns>
                             <asp:BoundField DataField="MaDonHang" HeaderText="Mã Đơn Hàng" 
                                 InsertVisible="False" ReadOnly="True" SortExpression="MaDonHang" />
                             <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                             <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" SortExpression="HoTen" />
                             <asp:BoundField DataField="NgayDatHang" HeaderText="Ngày Đặt Hàng" 
                                 SortExpression="NgayDatHang" />
                             <asp:BoundField DataField="NgayYeuCau" HeaderText="Ngày Yêu Cầu" 
                                 SortExpression="NgayYeuCau" />
                             <asp:BoundField DataField="DiaChiNhan" HeaderText="Địa Chỉ Nhận" 
                                 SortExpression="DiaChiNhan" />
                             <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" 
                                 SortExpression="TongTien" DataFormatString="{0:0,0} VND" />
                             <asp:ButtonField Text="Xác Nhận Thanh Toán" CommandName="Select"
                                 HeaderText="Xác Nhận" >
                             <ItemStyle Width="150px" />
                             </asp:ButtonField>
                         </Columns>
                         <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                         <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                         <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                         <RowStyle BackColor="White" ForeColor="#003399" />
                         <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                         <SortedAscendingCellStyle BackColor="#EDF6F6" />
                         <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                         <SortedDescendingCellStyle BackColor="#D6DFDF" />
                         <SortedDescendingHeaderStyle BackColor="#002876" />
                     </asp:GridView>
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                         ConnectionString="<%$ ConnectionStrings:WebBanDTConnectionString %>" SelectCommand="SELECT TOP 1 a.[MaDonHang]
      ,a.[Email]
      ,b.[HoTen]
      ,a.[NgayDatHang]
      ,a.[NgayYeuCau]
      ,a.[DiaChiNhan]
      ,(select SUM(TongTien)
from GioHang
where MaDonHang = (SELECT TOP 1 a.[MaDonHang]
from DonHang a, NguoiDung b, GioHang c
where a.MaDonHang = c.MaDonHang
order by a.MaDonHang desc)) as TongTien
from DonHang a, NguoiDung b, GioHang c
where a.MaDonHang = c.MaDonHang
order by a.MaDonHang desc"></asp:SqlDataSource>
                 </p>
               </td>
          </tr>
          <tr>
             <td align="center">
                  <p style=" color:Red;">
                     Quý khách vui lòng thanh toán tiền qua tài khoản để chúng tôi gửi hàng trong thời gian sớm nhất<br /></p>
                     <table id="tableThanhToan" class="style1" style="border: thin ridge #99FF99">
                         <tr>
                             <td align="center" 
                                 style="border: thin ridge #00FF00; font-size: large; color: #0000FF; text-decoration: underline" 
                                 width="50%">
                                 Thanh Toán An Toàn Qua BaoKim.vn</td>
                             <td style="border: thin ridge #00FF00; font-size: large; color: #0000FF; text-decoration: underline;" 
                                 width="50%" align="center">
                                 Thanh Toán An Toàn Qua NgânLượng.vn</td>
                         </tr>
                         <tr>
                             <td style="border: thin ridge #99FF99" align="center">
                      <asp:ImageButton ID="imgThanhToanBaoKim" runat="server" 
                          ImageUrl="~/image_ThanhToan/baokim_Payment.png" Visible="False" 
                                     onclick="imgThanhToanBaoKim_Click" />
                                 &nbsp;</td>
                             <td style="border: thin ridge #99FF99" align="center">
                      <asp:ImageButton ID="imgThanhThoan" runat="server" 
                          ImageUrl="~/image_ThanhToan/11.gif" onclick="imgThanhThoan_Click" 
                          Visible="False" />
                                 &nbsp;</td>
                         </tr>
                  </table>
                      <p>Cảm ơn quý khách đã sử dụng dịch vụ của chúng tôi.<br />
                     <asp:HyperLink ID="hplktrangchu" runat="server" NavigateUrl="~/TrangChu.aspx">Trở về trang chủ</asp:HyperLink>
                  </p>
             </td>
          </tr>
      </table>
   </asp:View>
   <asp:View ID="view3" runat="server">
     <table style=" width:100%;">
       <tr>
          <td align="center">
             <h3>Giỏ hàng của bạn</h3>
          </td>
       </tr>
       <tr align="center">
         <td align="center" style=" width:100%;">
             <p style=" color:Red;">
                Hãy đăng nhập để có thể mua hàng 
                 <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Thanhviendangnhap.aspx" 
                     ForeColor="#0033CC">Đăng nhập</asp:HyperLink>
                <br />
                Nếu bạn chưa có tài khoản tiến hành: 
                 <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="Blue" 
                     NavigateUrl="~/DangKy.aspx">Đăng ký</asp:HyperLink>
             </p>
         </td>
       </tr>
     </table>
   </asp:View>
   <asp:View ID="view4" runat="server">
      <table align="center" style=" width:100%;">
        <tr>
          <td align="center">
             <h3 style=" color:Red;">Lỗi hệ thống</h3>
          </td>
        </tr>
      </table>
   </asp:View>
</asp:MultiView>
    
</asp:Content>

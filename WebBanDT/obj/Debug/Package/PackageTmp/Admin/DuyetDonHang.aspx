<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="DuyetDonHang.aspx.cs" Inherits="WebBanDT.Admin.DuyetDonHang" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <asp:MultiView ID="multiview1" runat="server">
     <asp:View ID="view1" runat="server">
       <table style="width:100%; height:250px;">
          <tr align="center">
             <td align="center">
                 <asp:ScriptManager ID="ScriptManager1" runat="server">
                 </asp:ScriptManager>

            <a>Từ Ngày: </a><asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>&nbsp<a>(yyyy/mm/dd)</a>

             <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtStartDate"  
                     runat="server" Format="yyyy/MM/dd" /> 
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             <a>Đến Ngày: </a><asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>&nbsp<a>(yyyy/mm/dd)</a>
             <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="txtEndDate" 
                     runat="server" Format="yyyy/MM/dd"/> 
              <br />
              <br />
                 <asp:Button ID="Button1" runat="server" Text="Xem Đơn Hàng" 
                     onclick="Button1_Click" />
              <br />
                 <br />
                 <asp:Label ID="LbThongbao" runat="server" ForeColor="Blue"></asp:Label>
              <br /><br />
             <asp:GridView ID="GridView3" runat="server" 
            onselectedindexchanged="GridView3_SelectedIndexChanged" 
            AutoGenerateSelectButton="True" DataKeyNames="MaDonHang" 
            AutoGenerateColumns="False"
             BackColor="White" BorderColor="Blue" BorderStyle="Dashed" 
            onrowcancelingedit="GridView3_RowCancelingEdit" 
            onrowdeleting="GridView3_RowDeleting" onrowediting="GridView3_RowEditing" onrowupdating="GridView3_RowUpdating"
            >
            <Columns>
                <asp:BoundField DataField="MaDonHang" HeaderText="Mã đơn hàng" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ tên" ReadOnly="True" />
                <asp:BoundField DataField="NgayYeuCau" HeaderText="Ngày yêu cầu" 
                    ReadOnly="True" />
                <asp:BoundField DataField="NgayDatHang" HeaderText="Ngày đặt hàng" 
                    ReadOnly="True" />
                <asp:BoundField DataField="DiaChiNhan" HeaderText="Địa chỉ nhận" 
                    ReadOnly="True" />
                <asp:TemplateField HeaderText="Ngày chuyển hàng">
                   <ItemTemplate>
                     <asp:Label ID="lbNgayChuyenhang" runat="server" Text='<%# Bind("NgayChuyen") %>' ></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                     <asp:TextBox ID="txtNgayChuyen" runat="server" Text='<%# Eval("NgayChuyen") %>'></asp:TextBox>
                   </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tình trạng">
                  <ItemTemplate>
                     <asp:Label ID="lbTinhTrang" runat="server" Text='<%# Bind("TinhTrang") %>'></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtTinhTrang" runat="server" Text='<%# Eval("TinhTrang") %>'></asp:TextBox>
                  </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                   <ItemTemplate>
                       <asp:ImageButton ID="imgbtn1" runat="server" CommandName="Edit" ToolTip="Edit" ImageUrl="~/images/edit.png" />
                   </ItemTemplate>
                   <EditItemTemplate>
                     <asp:ImageButton ID="imgbtn2" runat="server" CommandName="Cancel" ToolTip="Cancel" ImageUrl="~/images/back.png" />
                     <asp:ImageButton ID="imgbtn3" runat="server" CommandName="Update" ToolTip="Update" ImageUrl="~/images/Save.png" />
                   </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xóa">
                  <ItemTemplate>
                    <asp:ImageButton ID="imgbtn4" runat="server" CommandName="Delete" ToolTip="Delete" ImageUrl="~/images/Delete.png" />
                  </ItemTemplate>
                </asp:TemplateField>
            </Columns>
             <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <br /> <br />
        <!----------------------------------------------------------------------->
                <asp:GridView ID="GridView1" runat="server" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
            AutoGenerateSelectButton="True" DataKeyNames="MaDonHang" 
            AutoGenerateColumns="False"
             BackColor="White" BorderColor="Blue" BorderStyle="Dashed" 
            onrowcancelingedit="GridView1_RowCancelingEdit" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing" onrowupdating="GridView1_RowUpdating"
            >
            <Columns>
                <asp:BoundField DataField="MaDonHang" HeaderText="Mã đơn hàng" 
                    ReadOnly="True" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ tên" ReadOnly="True" />
                <asp:BoundField DataField="NgayYeuCau" HeaderText="Ngày yêu cầu" 
                    ReadOnly="True" />
                <asp:BoundField DataField="NgayDatHang" HeaderText="Ngày đặt hàng" 
                    ReadOnly="True" />
                <asp:BoundField DataField="DiaChiNhan" HeaderText="Địa chỉ nhận" 
                    ReadOnly="True" />
                <asp:TemplateField HeaderText="Ngày chuyển hàng">
                   <ItemTemplate>
                     <asp:Label ID="lbNgayChuyenhang" runat="server" Text='<%# Bind("NgayChuyen") %>' ></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                     <asp:TextBox ID="txtNgayChuyen" runat="server" Text='<%# Eval("NgayChuyen") %>'></asp:TextBox>
                   </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tình trạng">
                  <ItemTemplate>
                     <asp:Label ID="lbTinhTrang" runat="server" Text='<%# Bind("TinhTrang") %>'></asp:Label>
                  </ItemTemplate>
                  <EditItemTemplate>
                     <asp:TextBox ID="txtTinhTrang" runat="server" Text='<%# Eval("TinhTrang") %>'></asp:TextBox>
                  </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sửa">
                   <ItemTemplate>
                       <asp:ImageButton ID="imgbtn1" runat="server" CommandName="Edit" ToolTip="Edit" ImageUrl="~/images/edit.png" />
                   </ItemTemplate>
                   <EditItemTemplate>
                     <asp:ImageButton ID="imgbtn2" runat="server" CommandName="Cancel" ToolTip="Cancel" ImageUrl="~/images/back.png" />
                     <asp:ImageButton ID="imgbtn3" runat="server" CommandName="Update" ToolTip="Update" ImageUrl="~/images/Save.png" />
                   </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xóa">
                  <ItemTemplate>
                    <asp:ImageButton ID="imgbtn4" runat="server" CommandName="Delete" ToolTip="Delete" ImageUrl="~/images/Delete.png" />
                  </ItemTemplate>
                </asp:TemplateField>
            </Columns>
             <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <!------------------------------------------------------------------------------------>
             </td>
          </tr>
       </table>
        
     </asp:View>
     <asp:View ID="view2" runat="server">
     <table style=" width:100%; height: 250px;">
       <tr>
         <td align="center">
            <asp:Label ID="lbthongtin" runat="server" Text="Thông tin đơn hàng" ForeColor="Red" Font-Size="XX-Large"></asp:Label>
         </td>
       </tr>
       <tr> 
         <td align="center">
            <table style="color: #0000FF">
              <tr>
              <td align="left">
              Họ tên:
              </td>
              <td align="left">
                 <asp:Label ID="lbHoTen" runat="server"></asp:Label>
              </td>
              </tr>
              <tr>
                 <td align="left">
                 Email:
                 </td>
                 <td align="left">
                  <asp:Label ID="lbEmail" runat="server"></asp:Label>
                 </td>
              </tr>
              <tr>
                  <td align="left">
                  Địa chỉ Gửi:
                  </td>
                  <td align="left">
                   <asp:Label ID="lbDiaChiGui" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
                 <td>
                   Ngày đặt hàng:
                 </td>
                 <td>
                    <asp:Label ID="lbNgayDatHang" runat="server"></asp:Label>
                 </td>
              </tr>
              <tr>
                <td>
                   Ngày Yêu cầu:
                </td>
                <td>
                   <asp:Label ID="lbNgayYeuCau" runat="server"></asp:Label>
                </td>
              </tr>
            </table>
         </td>
       </tr>
       <tr>
            <td align="center">
            <asp:GridView ID="gridview2" runat="server" AutoGenerateColumns="false" 
     PageSize="5" 
     DataKeyNames="MaDonHang"
     AllowPaging="true"
     BackColor="White" BorderColor="Blue" BorderStyle="Dashed" 
    >
      <Columns>
        <asp:TemplateField HeaderText="Mã sản phẩm">
          <ItemTemplate>
             <asp:Label ID="lbMaSanPham" runat="server" Width="150px" Text='<%# Bind("MaSanPham") %>'></asp:Label>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tên sản phẩm">
          <ItemTemplate>
             <asp:Label ID="lbTenSanPham" runat="server" Width="200px" Text='<%# Bind("TenSanPham") %>'></asp:Label>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Đơn giá">
          <ItemTemplate>
             <asp:Label ID="lbDonGia" runat="server" Width="150px" Text='<%# Bind("DonGia","{0:0,0} VND") %>'></asp:Label>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField  HeaderText="Số lượng">
          <ItemTemplate>
             <asp:Label ID="lbSoLuong" runat="server" Width="150px" Text='<%# Bind("SoLuong") %>'></asp:Label>
          </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Tổng tiền" >
            <ItemTemplate>
               <asp:Label ID="lbTongTien" runat="server" Width="150px" Text='<%# Bind("TongTien","{0:0,0} VND") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
      </Columns>
       <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
            </td>
       </tr>
     </table>
      
     </asp:View>
   </asp:MultiView>
</asp:Content>

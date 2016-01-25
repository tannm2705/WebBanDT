<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KieuDang.aspx.cs" Inherits="WebBanDT.Admin.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="wapper">
     <div id="dangnhap">
             <div style=" height:50px;">
                  <h2 style=" padding-top:15px; padding-left:100px; height:30px; color:Blue;">Nhập thông tin kiểu dáng</h2>
            </div>
            <div style=" height:50px; width:477px;">
               <div style=" margin-left:70px; margin-top:10px; width:130px; height:30px; float:left"><h3 style=" color:Maroon; height:30px;">Mã kiểu dáng:</h3></div>
               <div style=" margin-left:10px; margin-top:15px; width:200px; float:left"><asp:TextBox ID="txtMaKieuDang" runat="server" Width="200px" Height="30px"></asp:TextBox></div>
            </div>
            <div style=" height:50px; width:477px;">
                  <div style=" margin-left:70px; margin-top:10px; width:130px; height:30px; float:left"><h3 style=" color:Maroon; height:30px;">Tên kiểu dáng:</h3></div>
                  <div style=" margin-left:10px; margin-top:15px; width:200px; float:left"><asp:TextBox ID="txtTenKieuDang" runat="server" Width="200px" Height="30px"></asp:TextBox></div>
            </div>
            <div style=" height:80px; width:477px;">
                 <div style=" width:100px; height:35px; margin-left:200px; margin-top:20px; float:left">
                     <asp:Button ID="btnThemKieuDang" runat="server"  Text="Thêm kiểu dáng" Width="120px" Height="35px" OnClick="ThemKieuDang_Click"/>
                 </div>
            </div>
            <div><asp:Label ID="lableThongbao" runat="server"></asp:Label></div>
     </div>
     <div id="dieukhien">
     <table style=" width:100%; height:100%; float:left;">
         <tr>
            <td align="center">
        <asp:GridView ID="grv_KieuDang" runat="server"
        AutoGenerateColumns="false"
        AllowPaging="true"
        PageSize="5"
        BackColor="White" 
        BorderColor="#3366CC"
        BorderStyle="None" 
        BorderWidth="1px" 
        CellPadding="4"
        OnPageIndexChanging="grv_PageChangging"
        OnRowEditing="grv_RowEditing"
        OnRowCancelingEdit="grv_RowCancelingEdit"
        OnRowUpdating="grv_RowUpdating"
        OnRowDeleting="grv_RowDeleting"
        DataKeyNames="MaKieuDang"
       >
                  <Columns>
                       <asp:TemplateField HeaderText="Mã kiểu dáng">
                           <ItemTemplate>
                              <asp:Label ID="lbMaKieuDang" runat="server" Text='<%# Bind("MaKieuDang") %>'></asp:Label>
                           </ItemTemplate>
                           <EditItemTemplate>
                               <asp:TextBox ID="txtMaKieuDang" runat="server" Text='<%# Eval("MaKieuDang") %>' ReadOnly="true"></asp:TextBox>
                           </EditItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Tên Kiểu dáng">
                         <ItemTemplate>
                            <asp:Label ID="lbTenKieuDang" runat="server" Text='<%# Bind("TenKieuDang") %>'></asp:Label>
                         </ItemTemplate>
                         <EditItemTemplate>
                            <asp:TextBox ID="txtTenKieuDang" runat="server" Text='<%# Eval("TenKieuDang") %>'></asp:TextBox>
                         </EditItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Edit">
                          <ItemTemplate>
                             <asp:ImageButton ID="imgbtn1" runat="server" CommandName="Edit" ToolTip="Edit" ImageUrl="~/images/edit.png" />
                          </ItemTemplate>
                          <EditItemTemplate>
                             <asp:ImageButton ID="imgbtn2"  runat="server" CommandName="Update" ToolTip="Update" ImageUrl="~/images/Save.png" />
                             <asp:ImageButton ID="imgbtn3" runat="server" CommandName="Cancel" ToolTip="Cancel" ImageUrl="~/images/back.png" />
                          </EditItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Delete">
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
            </td>
         </tr>
     </table>
     </div>
     <div id="list">
     </div>
</div>

</asp:Content>

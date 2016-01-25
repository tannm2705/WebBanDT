<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="TinRaoVat.aspx.cs" Inherits="WebBanDT.Admin.TinRaoVat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style=" width:100%;">
  <tr> 
    <td align="center">
       <h2 style=" color:Red;">Quản lý tin rao vặt</h2>
    </td>
  </tr>
  <tr>
     <td>
        <table style=" width:100%;">
           <tr>
             <td>
                Tiêu đề:
             </td>
             <td>
               <asp:TextBox ID="txtTieu_De" runat="server"></asp:TextBox>
             </td>
             <td>
               Đuường dẫn
             </td>
             <td>
               <asp:TextBox ID="txt_Link" runat="server"></asp:TextBox>
             </td>
             <td>
               Ngày đăng:
             </td>
             <td>
                <asp:TextBox ID="txt_NgayDang" runat="server"></asp:TextBox>
             </td>
             <td>
                <asp:Button ID="btnThem" runat="server" Text="Thêm tin" Height="30px" 
                     onclick="btnThem_Click" />
             </td>
           </tr>
        </table>
     </td>
  </tr>
  <tr>
     <td align="center">
        <h3 style=" color:Blue;">Danh sách cách tin</h3>
     </td>
  </tr>
  <tr>
    <td align="center">
        <asp:GridView ID="gridview1" runat="server"
         AllowPaging="True"
         AutoGenerateColumns="False"
         DataKeyNames="MaTin"
         PageSize="4"
         BackColor="White" BorderColor="Blue" BorderStyle="Dashed" 
            onpageindexchanging="gridview1_PageIndexChanging" 
            onrowcancelingedit="gridview1_RowCancelingEdit" 
            onrowdeleting="gridview1_RowDeleting" onrowediting="gridview1_RowEditing" onrowupdating="gridview1_RowUpdating" 
        >
        <Columns>
          <asp:TemplateField HeaderText="Mã tin">
             <ItemTemplate>
               <asp:Label ID="lbMaTin" runat="server" Text='<%# Bind("MaTin") %>' ></asp:Label>
             </ItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Tiêu đề">
            <ItemTemplate>
              <asp:Label ID="lbTieuDe" runat="server" Text='<%# Bind("TieuDe") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
               <asp:TextBox ID="txtTieuDe" runat="server" Width="250px" Text='<%# Eval("TieuDe") %>'></asp:TextBox>
            </EditItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Đường dẫn">
            <ItemTemplate>
              <asp:Label ID="lbLink" runat="server" Text='<%# Bind("Link") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
              <asp:TextBox ID="txtLink" runat="server" Width="400px" Text='<%# Eval("Link") %>'></asp:TextBox>
            </EditItemTemplate>
          </asp:TemplateField>
          <asp:TemplateField HeaderText="Ngày đăng">
            <ItemTemplate>
               <asp:Label ID="lbNgayDang" runat="server" Text='<%# Bind("NgayDang") %>' ></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
              <asp:TextBox ID="txtNgayDang" runat="server" Text='<%# Eval("NgayDang") %>'></asp:TextBox>
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
</asp:Content>

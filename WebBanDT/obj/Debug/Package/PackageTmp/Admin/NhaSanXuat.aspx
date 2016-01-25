<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="NhaSanXuat.aspx.cs" Inherits="WebBanDT.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="wapper">
     <div id="dangnhap">
             <div style=" height:50px;">
                  <h2 style=" padding-top:15px; padding-left:100px; height:30px; color:Blue;">Nhập thông tin Nhà sản xuất</h2>
            </div>
            <div style=" height:50px; width:477px;">
               <div style=" margin-left:70px; margin-top:10px; width:130px; height:30px; float:left"><h3 style=" color:Maroon; height:30px;">Mã nhà SX:</h3></div>
               <div style=" margin-left:10px; margin-top:15px; width:200px; float:left"><asp:TextBox ID="txtMaNSX" runat="server" Width="200px" Height="30px"></asp:TextBox></div>
            </div>
            <div style=" height:50px; width:477px;">
                  <div style=" margin-left:70px; margin-top:10px; width:130px; height:30px; float:left"><h3 style=" color:Maroon; height:30px;">Tên nhà SX:</h3></div>
                  <div style=" margin-left:10px; margin-top:15px; width:200px; float:left"><asp:TextBox ID="txtTenNSX" runat="server" Width="200px" Height="30px"></asp:TextBox></div>
            </div>
            <div style=" height:80px; width:477px;">
                 <div style=" width:100px; height:35px; margin-left:200px; margin-top:20px; float:left">
                     <asp:Button ID="btnThemNSX" runat="server"  Text="Thêm Nhà SX" Width="120px" Height="35px" OnClick="ThemNhaSX_Click"/>
                 </div>
            </div>
            <div><asp:Label ID="lableThongbao" runat="server"></asp:Label></div>
     </div>
     <div id="dieukhien">
     <table style=" width:100%; height:100%; float:left;">
         <tr>
            <td align="center">
                 <asp:GridView ID="grv_NhaSX" runat="server"
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
        DataKeyNames="MaNSX"
       >
                  <Columns>
                       <asp:TemplateField HeaderText="Mã nhà sản xuất">
                           <ItemTemplate>
                              <asp:Label ID="lbMaNSX" runat="server" Text='<%# Bind("MaNSX") %>'></asp:Label>
                           </ItemTemplate>
                           <EditItemTemplate>
                               <asp:TextBox ID="txtMaNSX" runat="server" Text='<%# Eval("MaNSX") %>' ReadOnly="true"></asp:TextBox>
                           </EditItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField HeaderText="Tên nhà sản xuất">
                         <ItemTemplate>
                            <asp:Label ID="lbTenNSX" runat="server" Text='<%# Bind("TenNSX") %>'></asp:Label>
                         </ItemTemplate>
                         <EditItemTemplate>
                            <asp:TextBox ID="txtTenNSX" runat="server" Text='<%# Eval("TenNSX") %>'></asp:TextBox>
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

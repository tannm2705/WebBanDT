<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GridViewXoaSua.ascx.cs" Inherits="WebBanDT.Controler.GridViewXoaSua" %>
       <asp:GridView ID="grvNguoiDung" runat="server" AutoGenerateColumns="False"
             AllowPaging="true"
             PageSize="7"
            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" DataKeyNames="Email" 
            onrowcancelingedit="grvProduct_RowCancelingEdit" onrowdeleting="grvProduct_RowDeleting" 
            onrowediting="grvProduct_RowEditing" onrowupdating="grvProduct_RowUpdating" 
            ShowFooter="True" Width="813px" 
    onpageindexchanging="grvNguoiDung_PageIndexChanging">
            <RowStyle ForeColor="#000066" />
            <Columns>
                <asp:TemplateField>
                    <FooterTemplate>
                    </FooterTemplate>
                    <HeaderTemplate>
                    </HeaderTemplate>
                    <HeaderStyle HorizontalAlign="Left" />
                </asp:TemplateField>
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" />
                <asp:BoundField DataField="MatKhau" HeaderText="Mật Khẩu" />
                <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" />
                <asp:BoundField DataField="DiaChi" HeaderText="Địa chỉ" />
                <asp:BoundField DataField="SoDT" HeaderText="Số DT" />
                <asp:BoundField DataField="SoFax" HeaderText="Số Fax" />
                <asp:BoundField DataField="MaKieuNguoiDung" HeaderText="Mã Kiểu Use" />
                <asp:TemplateField HeaderText="Sửa">
                    <EditItemTemplate>
                        <asp:ImageButton ID="ImageButton2" runat="server" CommandName="update" 
                            ImageUrl="~/icons/disk.png" ToolTip="Cập nhật" />
                        <asp:ImageButton ID="ImageButton3" runat="server" CommandName="cancel" 
                            ImageUrl="~/icons/arrow_undo.png" ToolTip="Bỏ qua" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" CommandName="edit" 
                            ImageUrl="~/icons/application_edit.png" ToolTip="Sửa" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Xóa">
                    <ItemTemplate>
                        <asp:ImageButton ID="imgDel" runat="server" CommandName="delete" 
                            ImageUrl="~/icons/cross_octagon_fram.png" ToolTip="Xóa" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    
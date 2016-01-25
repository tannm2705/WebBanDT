<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhSachAllNhaSX.ascx.cs" Inherits="WebBanDT.Controls.DanhSachAllNhaSX" %>
<style type="text/css">
    .style1
    {
        width: 100%;
    }
</style>

<table class="style1">
    <tr>
        <td>
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="100%">
            <Columns>
                <asp:TemplateField HeaderText="Hãng sản xuất">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server" 
                            NavigateUrl='<%# Eval("MaNSX","~/SanPhamTheoNSX.aspx?MaNSX={0}") %>' 
                            Text='<%# Eval("TenNSX") %>'></asp:HyperLink>
                    </ItemTemplate>
                    <HeaderStyle BorderColor="Red" BorderStyle="Dotted" 
                        Font-Names="Times New Roman" Font-Size="Medium" ForeColor="#333333" />
                    <ItemStyle BorderColor="Red" BorderStyle="Dotted" BorderWidth="1px" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </td>
    </tr>
</table>


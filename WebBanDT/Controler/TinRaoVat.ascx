<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TinRaoVat.ascx.cs" Inherits="WebBanDT.Controls.TinRaoVat" %>
<marquee direction="up" scrollamount="2" scrolldelay="40" scrollamount="1" truespeed="truespeed" onmouseover="this.stop()" onmouseout="this.start()" style=" height:250px; text-align: center">
     <table style=" width:200px; height:300px;">
     <tr>
        <td align="center">
            <asp:DataList ID="datalist1" runat="server" Width="200px">
                <ItemTemplate>
                    <table class="style1">
                        <tr>
                            <td>
                            </td>
                        </tr>
                        <tr style=" height:50px;">
                            <td align="left"><asp:Image ID="Image1" runat="server" 
                                    ImageUrl="~/icons/hot2.png" />
                                <br />
                            </td>
                            <td align="left">
                                
                                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" 
                                    Text='<%# Bind("TieuDe") %>' NavigateUrl='<%# Bind("Link","{0}") %>'></asp:HyperLink>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
           </asp:DataList>
        </td>
     </tr>
   </table>
</marquee>

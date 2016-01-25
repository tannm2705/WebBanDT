<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserRating.aspx.cs" Inherits="WebBanDT.UserRating" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title></title>
            <style type="text/css">
            .ratingEmpty
            {
            background-image: url(RatingStar/ratingStarEmpty.gif);
            width:18px;
            height:18px;
            }
            .ratingFilled
            {
            background-image: url(RatingStar/ratingStarFilled.gif);
            width:18px;
            height:18px;
            }
            .ratingSaved
            {
             background-image: url(RatingStar/ratingStarSaved.gif);
            width:18px;
            height:18px;
            }
                </style>
</head>
      <body>
        <form id="form1" runat="server">
                <div>
            <asp:UpdatePanel ID="pnlRating" runat="server">
                <ContentTemplate>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                 <table width="35%">
             <tr>
                 <td width="27%">
                 <b>Average Rating:</b>
                </td>
            <td>
         <ajax:Rating ID="ratingControl" AutoPostBack="true" OnChanged="RatingControlChanged" runat="server" StarCssClass="ratingEmpty" WaitingStarCssClass="ratingSaved" EmptyStarCssClass="ratingEmpty" FilledStarCssClass="ratingFilled">
             </ajax:Rating>
         <b> <asp:label ID="lbltxt" runat="server"/> </b>
          </td>
           </tr>
           </table>
         </ContentTemplate>
            </asp:UpdatePanel>
         </div>
         </form>
        </body>
        </html>

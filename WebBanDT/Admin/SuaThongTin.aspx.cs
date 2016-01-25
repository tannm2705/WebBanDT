using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Common;
using BusinessLogic;

namespace WebBanDT.Admin
{
    public partial class SuaThongTin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["TrangThai"].ToString() == "ChuaDangNhap")
            {
                Response.Redirect("~/Admin/Dangnhapadmin.aspx");
            }
        }


        protected void HuyBo_Click(object sender, EventArgs e)
        {

        }
    }
}
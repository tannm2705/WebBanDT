using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;


namespace WebBanDT.Web
{
    public partial class SanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThiAllSP1.Sosanpham = 24;
        }

    }
}
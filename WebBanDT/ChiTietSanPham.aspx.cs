using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanDT
{
    public partial class ChiTietSanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThongTinSanPham1.MaSP = int.Parse(Request.QueryString.Get("MaSanPham"));
        }
    }
}
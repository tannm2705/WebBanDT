using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace WebBanDT.Controls
{
    public partial class TinRaoVat : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyTruyXuatTinRaoVat tinraovat = new XulyTruyXuatTinRaoVat();
            tinraovat.Thucthi();
            datalist1.DataSource = tinraovat.Table;
            datalist1.DataBind();
        }
    }
}
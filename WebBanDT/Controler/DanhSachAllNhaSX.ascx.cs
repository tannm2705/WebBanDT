using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Select;
using BusinessLogic;

namespace WebBanDT.Controls
{
    public partial class DanhSachAllNhaSX : System.Web.UI.UserControl
    {
        XulyLayAllthongtinNhaSX nsx = new XulyLayAllthongtinNhaSX();
        protected void Page_Load(object sender, EventArgs e)
        {
            nsx.Thucthi();
            GridView1.DataSource = nsx.Ketqua;
            GridView1.DataBind();
        }
    }
}
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
    public partial class Hienthitinraovat : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyTruyXuatAllTopNSanPham topn = new XulyTruyXuatAllTopNSanPham();
            topn.Thucthi();
            datalist1.DataSource = topn.table;
            datalist1.DataBind();
        }
    }
}
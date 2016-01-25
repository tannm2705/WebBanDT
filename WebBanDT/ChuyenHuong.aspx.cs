using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebBanDT
{
    public partial class ChuyenHuong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable ddt = new DataTable();
            ddt = (DataTable)Session.Contents["TaiKhoan"];
            LbTen.Text = ddt.Rows[0]["HoTen"].ToString();
        }
    }
}
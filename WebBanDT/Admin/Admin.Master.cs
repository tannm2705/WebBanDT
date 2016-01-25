using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBanDT.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnThemNSX_Click(object sender, EventArgs e)
        {
            Response.Redirect("NhaSanXuat.aspx");
        }

        protected void btnThemkieudang_Click(object sender, EventArgs e)
        {
            Response.Redirect("KieuDang.aspx");
        }

        protected void btnthemsanpham_Click(object sender, EventArgs e)
        {
            Response.Redirect("TinRaoVat.aspx");
        }

        protected void btnthemphongcach_Click(object sender, EventArgs e)
        {
            Response.Redirect("DuyetDonHang.aspx");
        }

        protected void btnThemXoaUse_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuaThongTin.aspx");
        }

        protected void btnSanPham_Click(object sender, EventArgs e)
        {
            Response.Redirect("SanPham.aspx");
        }
        protected void btnTrangChu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TrangChu.aspx");
        }
    }
}
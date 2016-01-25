using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace WebBanDT.Admin
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["TrangThai"].ToString() == "ChuaDangNhap")
            {
                Response.Redirect("~/Admin/Dangnhapadmin.aspx");
            }
            else 
            {
                XulyTruyXuatAllThongTinSanpham sanpham = new XulyTruyXuatAllThongTinSanpham();
                sanpham.Thucthi_xuattable();
                CollectionPager1.MaxPages = 1000;
                CollectionPager1.PageSize = 12;
                CollectionPager1.DataSource = sanpham.table.DefaultView;
                CollectionPager1.BindToControl = datalist1;
                datalist1.DataSource = CollectionPager1.DataSourcePaged;
                datalist1.DataBind();
           }
        }

        protected void ThemSP_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThemSanPham.aspx");
        }
    }
}
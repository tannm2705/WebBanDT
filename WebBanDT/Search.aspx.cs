using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Common;

namespace WebBanDT
{
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XulySanPhamSearch search_SP = new XulySanPhamSearch();
            string search = Request["txtSearch"];
            search_SP.Ttsanpham.TenSanPham = "%"+Session.Contents["Search"].ToString()+"%";
            search_SP.Thucthi();
            CollectionPager1.MaxPages = 1000;
            CollectionPager1.PageSize = 20;
            CollectionPager1.DataSource = search_SP.Table.DefaultView;
            CollectionPager1.BindToControl = datalist1;
            datalist1.DataSource = CollectionPager1.DataSourcePaged;
            datalist1.DataBind();
        }
    }
}
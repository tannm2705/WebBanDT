using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace WebBanDT.Controler
{
    public partial class HienThiAllSP : System.Web.UI.UserControl
    {
        private int _sosanpham;

        public int Sosanpham
        {
            get { return _sosanpham; }
            set { _sosanpham = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyTruyXuatAllThongTinSanpham sanpham = new XulyTruyXuatAllThongTinSanpham();
            sanpham.Thucthi_xuattable();
            CollectionPager1.MaxPages = 1000;
            CollectionPager1.PageSize = Sosanpham;
            CollectionPager1.DataSource = sanpham.table.DefaultView;
            CollectionPager1.BindToControl = datalist1;
            datalist1.DataSource = CollectionPager1.DataSourcePaged;
            datalist1.DataBind();
        }
    }
}
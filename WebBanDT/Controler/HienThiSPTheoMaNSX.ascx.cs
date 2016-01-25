using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Common;
namespace WebBanDT.Controler
{
    public partial class HienThiSPTheoMaNSX : System.Web.UI.UserControl
    {
        private string _MaNSX;
        public string MaNSX { get { return _MaNSX; } set { _MaNSX = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyLayThongTinSanPhamByPhongCach phongcach = new XulyLayThongTinSanPhamByPhongCach();
            XulyTruyXuatAllThongTinSanPhamByMaNSX sanphamByMaNSX = new XulyTruyXuatAllThongTinSanPhamByMaNSX();
            sanphamByMaNSX.MaNSX.MaNSX = this.MaNSX;
            sanphamByMaNSX.Thucthi();
            CollectionPager1.MaxPages = 1000;
            CollectionPager1.PageSize = 28;
            CollectionPager1.DataSource = sanphamByMaNSX.ketqua.DefaultView;
            CollectionPager1.BindToControl = datalist1;
            datalist1.DataSource = CollectionPager1.DataSourcePaged;
            datalist1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataAccess.Select;
using BusinessLogic;


namespace WebBanDT.Controler
{
    public partial class HienThiSPTheoPC : System.Web.UI.UserControl
    {
        private string _maphongcach = "";
        public string Maphongcach { get { return _maphongcach; } set { _maphongcach = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyLayThongTinSanPhamByPhongCach phongcach = new XulyLayThongTinSanPhamByPhongCach();
            phongcach.thongtinsanpham.MaPhongCach = this.Maphongcach;
            phongcach.Thucthi();
            //nhasx.Thucthi_xuattable();
            CollectionPager1.MaxPages = 1000;
            CollectionPager1.PageSize = 8;
            CollectionPager1.DataSource = phongcach.table.DefaultView; //nhasx.table.DefaultView;
            CollectionPager1.BindToControl = datalist1;
            datalist1.DataSource = CollectionPager1.DataSourcePaged;
            datalist1.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using BusinessLogic;

namespace WebBanDT.Controler
{
    public partial class ThongTinSanPham : System.Web.UI.UserControl
    {
        private int _MaSP;
        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            XulyLayThongTinSanPhamByID sanphamID = new XulyLayThongTinSanPhamByID();
            sanphamID.thongtinsanpham.MaSanPham = this.MaSP;
            sanphamID.Thucthi();

            datalist1.DataSource = sanphamID.Dttable;
            datalist1.DataBind();
        }
    }
}
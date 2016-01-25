using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using DataAccess.Select;

namespace BusinessLogic
{
   public class XulyTruyXuatAllTopNSanPham
    {
        private ThongTinSanPham _thongtinsanpham = new ThongTinSanPham();
        public ThongTinSanPham thongtinsanpham
        {
            get { return _thongtinsanpham; }
            set { _thongtinsanpham = value; }
        }

        private DataTable _table;
        public DataTable table
        { get { return _table; } set { _table = value; } }

        public void Thucthi()
        {
            TruyXuatAllThongTinTopNSanpham topNsanpham = new TruyXuatAllThongTinTopNSanpham();
            topNsanpham.thongtinsanpham.top = 10;
            table = topNsanpham.table();
        }
    }
}

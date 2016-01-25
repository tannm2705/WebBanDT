using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using DataAccess.Select;
using Common;

namespace BusinessLogic
{
   public class XulySanPhamSearch
    {
        private ThongTinSanPham ttsanpham = new ThongTinSanPham();

        public ThongTinSanPham Ttsanpham
        {
            get { return ttsanpham; }
            set { ttsanpham = value; }
        }
        private DataTable table = new DataTable();

        public DataTable Table
        {
            get { return table; }
            set { table = value; }
        }
        public void Thucthi()
        {
            SanPhamSearch search_SP = new SanPhamSearch();
            search_SP.Ttsanpham.TenSanPham = Ttsanpham.TenSanPham;
            Table = search_SP.ketqua();
        }
    }
}

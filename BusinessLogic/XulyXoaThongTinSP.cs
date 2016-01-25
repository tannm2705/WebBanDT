using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Delete;

namespace BusinessLogic
{
   public class XulyXoaThongTinSP
    {
        private ThongTinSanPham thongtinSP = new ThongTinSanPham();

        public ThongTinSanPham ThongtinSP
        {
            get { return thongtinSP; }
            set { thongtinSP = value; }
        }

        public void Thucthi()
        {
            XoaSanPham delete_sp = new XoaSanPham();
            delete_sp.Thongtinsp.MaSanPham = ThongtinSP.MaSanPham;
            delete_sp.XoaDuLieu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
   public class XulySuaThongTinSanPham
    {
        private ThongTinSanPham _thongtinsanpham=new ThongTinSanPham();

        public ThongTinSanPham Thongtinsanpham
        {
            get { return _thongtinsanpham; }
            set { _thongtinsanpham = value; }
        }

        public void Thucthi()
        {
            SuaThongTinSanPham sp = new SuaThongTinSanPham();
            sp.ttsanpham = Thongtinsanpham;
            sp.Suadulieu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Insert;
using Common;

namespace BusinessLogic
{
   public class XulyThemSanPhamMoi
    {
        private ThongTinSanPham _ttsanpham;
        public ThongTinSanPham ttsanpham
        {
            get { return _ttsanpham; }
            set { _ttsanpham = value; }
        }

        public void Thucthi()
        {
            ThemSanPhamMoi insert_Sanphammoi = new ThemSanPhamMoi();
            insert_Sanphammoi.ttsanpham = this.ttsanpham;
            insert_Sanphammoi.Themdulieu();
        }
    }
}

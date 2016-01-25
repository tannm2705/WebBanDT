using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Insert;

namespace BusinessLogic
{
   public class XulyThemGioHang
    {

        private GioHang _giohang = new GioHang();

        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }

        public void Thucthi()
        {
            ThemGioHang insert_giohang = new ThemGioHang();
            insert_giohang.Giohang = this.Giohang;
            insert_giohang.Them_GioHang();
        }
    }
}

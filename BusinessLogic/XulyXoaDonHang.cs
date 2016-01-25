using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Delete;
using Common;

namespace BusinessLogic
{
   public class XulyXoaDonHang
    {
        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }

        public void Thuthi()
        {
            XoaDonHang Delete_Donhang = new XoaDonHang();
            Delete_Donhang.Donhang = this.Donhang;
            Delete_Donhang.Delete_Donhang();
        }
    }
}

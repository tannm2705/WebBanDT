using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Insert;
using Common;

namespace BusinessLogic
{
  public  class XulyThemDonHang
    {
        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }

        public void Thucthi()
        {
            ThemDonHang insert_dh = new ThemDonHang();
            insert_dh.Donhang = this.Donhang;
            insert_dh.Them_DonHang();
        }
    }
}

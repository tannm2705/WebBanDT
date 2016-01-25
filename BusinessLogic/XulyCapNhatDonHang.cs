using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Update;
using Common;


namespace BusinessLogic
{
  public  class XulyCapNhatDonHang
    {
        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }

        public void Thucthi()
        {
            CapNhatDonHang Update_Donhang = new CapNhatDonHang();
            Update_Donhang.Donhang = this.Donhang;
            Update_Donhang.Update_Donhang();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
   public class XulySuaThongTinNhaSX
    {
        private NhaSX _nhasx = new NhaSX();

        public NhaSX Nhasx
        {
            get { return _nhasx; }
            set { _nhasx = value; }
        }

        public void Thucthi()
        {
            SuaThongTinNhaSX update_nhasx = new SuaThongTinNhaSX();
            update_nhasx.Nsx.MaNSX = Nhasx.MaNSX;
            update_nhasx.Nsx.TenNSX = Nhasx.TenNSX;
            update_nhasx.suathongtinNSX();
        }
    }
}

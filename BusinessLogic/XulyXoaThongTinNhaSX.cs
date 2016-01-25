using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Delete;

namespace BusinessLogic
{
   public class XulyXoaThongTinNhaSX
    {
        private NhaSX nhasx = new NhaSX();

        public NhaSX Nhasx
        {
            get { return nhasx; }
            set { nhasx = value; }
        }

        public void Thucthi()
        {
            XoaThongTinNhaSX delete_nhasx = new XoaThongTinNhaSX();
            delete_nhasx.Nhasx.MaNSX = Nhasx.MaNSX;
            delete_nhasx.XoaDuLieu();
        }
    }
}

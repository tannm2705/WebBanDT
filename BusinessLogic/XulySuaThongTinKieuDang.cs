using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
   public class XulySuaThongTinKieuDang
    {
        private KieuDang _kieudang = new KieuDang();

        public KieuDang Kieudang
        {
            get { return _kieudang; }
            set { _kieudang = value; }
        }

        public void ThucThi()
        {
            SuaThongTinKieuDang update_kieudang = new SuaThongTinKieuDang();
            update_kieudang.Kieudang.MaKieuDang = Kieudang.MaKieuDang;
            update_kieudang.Kieudang.TenKieuDang = Kieudang.TenKieuDang;
            update_kieudang.SuaThongTin_KieuDang();
        }
    }
}

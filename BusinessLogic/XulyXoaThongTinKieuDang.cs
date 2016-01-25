using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using DataAccess.Delete;
using Common;

namespace BusinessLogic
{
   public class XulyXoaThongTinKieuDang
    {
        private KieuDang _kdang = new KieuDang();

        public KieuDang Kdang
        {
            get { return _kdang; }
            set { _kdang = value; }
        }
        public void Thucthi()
        {
            XoaThongTinKieuDang delete_kieudang = new XoaThongTinKieuDang();
            delete_kieudang.Kdang.MaKieuDang = Kdang.MaKieuDang;
            delete_kieudang.XoaDuLieu();
        }
    }
}

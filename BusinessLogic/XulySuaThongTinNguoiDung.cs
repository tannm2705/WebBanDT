using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Insert;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
   public class XulySuaThongTinNguoiDung
    {
        private NguoiDung _nguoidung;

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }

        public void Thucthi()
        {
            SuaThongTinNguoiDung updateUse = new SuaThongTinNguoiDung();
            updateUse.Nguoidung = this.Nguoidung;
            updateUse.Suathongtin();

        }
    }
}

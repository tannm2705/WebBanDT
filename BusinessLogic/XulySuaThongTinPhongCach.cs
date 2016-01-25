using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
  public class XulySuaThongTinPhongCach
    {
        private PhongCach _phongcach = new PhongCach();

        public PhongCach Phongcach
        {
            get { return _phongcach; }
            set { _phongcach = value; }
        }

        public void ThuThi()
        {
            SuaThongTinPhongCach update_phongcach = new SuaThongTinPhongCach();
            update_phongcach.Phongcach.MaPhongCach = Phongcach.MaPhongCach;
            update_phongcach.Phongcach.TenPhongCach = Phongcach.TenPhongCach;
            update_phongcach.SuathongtinPhongcach();
        }
    }
}

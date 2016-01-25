using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Delete;
using Common;

namespace BusinessLogic
{
   public class XulyXoaThongTinPhongCach
    {
        private PhongCach _phcach = new PhongCach();

        public PhongCach Phcach
        {
            get { return _phcach; }
            set { _phcach = value; }
        }

        public void Thucthi()
        {
            XoaThongTinPhongCach delete_phongcach = new XoaThongTinPhongCach();
            delete_phongcach.Phcach.MaPhongCach = Phcach.MaPhongCach;
            delete_phongcach.XoaDuLieu();
        }
    }
}

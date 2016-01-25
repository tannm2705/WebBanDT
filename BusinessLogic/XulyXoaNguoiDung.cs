using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Delete;

namespace BusinessLogic
{
   public class XulyXoaNguoiDung
    {
        private NguoiDung _nguoidung = new NguoiDung();

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }

        public void Thucthi()
        {
            XoaNguoiDung deleteUse = new XoaNguoiDung();
            deleteUse.Nguoidung.Email = this.Nguoidung.Email;
            deleteUse.XoaDuLieu();
        }
    }
}

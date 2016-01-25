using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class KieuNguoiDung
    {
        private int _MaKieuNguoiDung;
        private string _TenKieuNguoiDung;


        public int MaKieuNguoiDung
        {
            get { return _MaKieuNguoiDung; }
            set { _MaKieuNguoiDung = value; }
        }
        public string TenKieuNguoiDung
        {
            get { return _TenKieuNguoiDung; }
            set { _TenKieuNguoiDung = value; }
        }
    }
}

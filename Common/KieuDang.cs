using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class KieuDang
    {
       public KieuDang() { }
        private string _MaKieuDang;
        private string _TenKieuDang;


        public string MaKieuDang
        {
            get { return _MaKieuDang; }
            set { _MaKieuDang = value; }
        }
        public string TenKieuDang
        {
            get { return _TenKieuDang; }
            set { _TenKieuDang = value; }
        }
    }
}

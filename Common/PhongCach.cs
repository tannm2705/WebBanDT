using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class PhongCach
    {
       public PhongCach() { }
        private string _MaPhongCach;
        private string _TenPhongCach;


        public string MaPhongCach
        {
            get { return _MaPhongCach; }
            set { _MaPhongCach = value; }
        }
        public string TenPhongCach
        {
            get { return _TenPhongCach; }
            set { _TenPhongCach = value; }
        }
    }
}

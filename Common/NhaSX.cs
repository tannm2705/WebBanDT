using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class NhaSX
    {
       public NhaSX() { }
       private string _MaNSX;

       public string MaNSX
       {
           get { return _MaNSX; }
           set { _MaNSX = value; }
       }

       private string _TenNSX;
       public string TenNSX
       {
           get { return _TenNSX; }
           set { _TenNSX = value; }
       }
    }
}

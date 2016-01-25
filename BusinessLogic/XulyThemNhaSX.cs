using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Insert;
using Common;

namespace BusinessLogic
{
   public class XulyThemNhaSX
    {
       private NhaSX _nhasx;
       public NhaSX nhasx
       {
           get { return _nhasx; }
           set { _nhasx = value; }
       }

       public void Thucthi()
       {
           ThemNhaSX insert_nhasx = new ThemNhaSX();
           insert_nhasx.nhasx = this.nhasx;
           insert_nhasx.Themdulieu();
       }
    }
}

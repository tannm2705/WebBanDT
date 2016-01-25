using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Insert;

namespace BusinessLogic
{
   public class XulyThemKieuDang
    {
       private KieuDang _kieudang;
       public KieuDang kieudang
       {
           get { return _kieudang; }
           set { _kieudang = value; }
       }

       public void Thucthi()
       {
           ThemKieuDang insert_kieudang = new ThemKieuDang();
           insert_kieudang.kieudang = this.kieudang;
           insert_kieudang.Themdulieu();
       }
    }
}

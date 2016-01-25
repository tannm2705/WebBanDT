using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Insert;

namespace BusinessLogic
{
   public class XulyThemPhongCach
    {
       private PhongCach _phongcach;
       public PhongCach phongcach
       {
           get { return _phongcach; }
           set { _phongcach = value; }
       }

       public void Thucthi()
       {
           ThemPhongCach insert_phongcach = new ThemPhongCach();
           insert_phongcach.phongcach = this.phongcach;
           insert_phongcach.Themdulieu();
       }
    }
}

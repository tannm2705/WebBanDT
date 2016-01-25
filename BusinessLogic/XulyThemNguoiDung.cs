using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Insert;

namespace BusinessLogic
{
   public class XulyThemNguoiDung
    {
       private NguoiDung _nguoidung=new NguoiDung();
       public NguoiDung nguoidung
       {
           get { return _nguoidung; }
           set { _nguoidung = value; }
       }

       public void Thucthi()
       {
           ThemNguoiDung insert_nguoidung = new ThemNguoiDung();
           insert_nguoidung.nguoidung = this.nguoidung;
           insert_nguoidung.Themdulieu();
       }
    }
}

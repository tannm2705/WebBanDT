using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Select;
using System.Data;

namespace BusinessLogic
{

   public class XulyTruyXuatAllThongTinSanpham
    {
       
       private DataTable _table;
       public DataTable table
       {
           get { return _table; }
           set { _table = value; }
       }
       public void Thucthi_xuattable()
       {
           TruyXuatAllThongTinSanPham sanpham = new TruyXuatAllThongTinSanPham();
           table = sanpham.Lay_table();
       }

    }


}

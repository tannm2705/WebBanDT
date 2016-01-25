using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess.Select;
using Common;

namespace BusinessLogic
{
  public  class XulyTruyXuatAllThongTinSanPhamByMaNSX
    {

      private ThongTinSanPham _MaNSX = new ThongTinSanPham();
      public ThongTinSanPham MaNSX
      { get { return _MaNSX; } set { _MaNSX = value; } }

      private DataTable _ketqua;
      public DataTable ketqua { get { return _ketqua; } set { _ketqua = value; } }

      public void Thucthi()
      {
          TruyXuatAllThongTinSanPhamByMaNSX thongtinspByNSX = new TruyXuatAllThongTinSanPhamByMaNSX();
          thongtinspByNSX.MaNSX.MaNSX = this.MaNSX.MaNSX;
          ketqua = thongtinspByNSX.table();
      }
    }
}

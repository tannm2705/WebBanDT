using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using Common;
using DataAccess.Select;

namespace BusinessLogic
{
  public  class XulyLayThongTinSanPhamByID
    {

        private int _dong;

        public int Dong
        {
            get { return _dong; }
            set { _dong = value; }
        }
      private ThongTinSanPham _thongtinsanpham=new ThongTinSanPham();
      public ThongTinSanPham thongtinsanpham
      {
          get { return _thongtinsanpham; }
          set { _thongtinsanpham = value; }
      }

      private SqlDataSource _ketqua;
      public SqlDataSource ketqua
      { get { return _ketqua; } set { _ketqua = value; } }

      private DataTable _datatable;

      public DataTable Dttable
      {
          get { return _datatable; }
          set { _datatable = value; }
      }

      
      public void Thucthi()
      {
          TruyXuatThongTinSanPhamByID sanphamID = new TruyXuatThongTinSanPhamByID();
          sanphamID.thongtinsanpham.MaSanPham =this.thongtinsanpham.MaSanPham;
          Dttable = sanphamID.table();
          foreach (DataRow row in Dttable.Rows)
          {
              if (int.Parse(row[0].ToString()) == thongtinsanpham.MaSanPham)
              { 
                // thongtinsanpham.MaSanPham = int.Parse(row[0].ToString());
                 thongtinsanpham.Nhasx.TenNSX =row[1].ToString();
                 thongtinsanpham.Kieudang.TenKieuDang = row[2].ToString();
                 thongtinsanpham.Phongcach.TenPhongCach = row[3].ToString();
                 thongtinsanpham.TenSanPham = row[4].ToString();
                 thongtinsanpham.MoTa = row[5].ToString();
                 thongtinsanpham.GiaSanPham = int.Parse(row[6].ToString());
                 thongtinsanpham.SoLuong = int.Parse(row[8].ToString());
                 thongtinsanpham.ImageSP = row[7].ToString();
                 thongtinsanpham.TenHDH = row[9].ToString();
                 thongtinsanpham.RAM = row[10].ToString();
                 thongtinsanpham.Camera = row[11].ToString();
                 thongtinsanpham.Pin = int.Parse(row[12].ToString());
                 return;
              }
          }

      }
    }
}

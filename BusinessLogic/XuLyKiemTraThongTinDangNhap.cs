using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Select;
using System.Data;
using System.Web.UI.WebControls;

namespace BusinessLogic
{
  public  class XuLyKiemTraThongTinDangNhap
    {

      private NguoiDung _nguoidung = new NguoiDung();
      public NguoiDung nguoidung
      {
          get { return _nguoidung; }
          set { _nguoidung = value; }
      }

      public string Use;
      public string Pass;

      public int Thucthi()
      {
          TruyXuatDangNhapNguoiDung loginuse = new TruyXuatDangNhapNguoiDung();
          DataTable table = new DataTable();
          table = loginuse.Laydulieu();
          foreach (DataRow row in table.Rows)
          {
              if ((row[0].ToString().ToLower().CompareTo(nguoidung.Email.ToLower()) == 0) && (row[1].ToString().ToLower().CompareTo(nguoidung.MatKhau.ToLower()) == 0))
              {
                  Use = nguoidung.Email; Pass = nguoidung.MatKhau;
                  if (int.Parse(row[2].ToString()) == 1)
                  {
                      return 1;//dang nhap voi quyen administrator
                     
                  }
                  return 2;//dang nhap voi quyen nguoi dung
              }
          }

          return 0;//dang nhap ko dung
      }
      public int KiemTraEmail()
      {
          TruyXuatDangNhapNguoiDung loginuse = new TruyXuatDangNhapNguoiDung();
          DataTable table = new DataTable();
          table = loginuse.Laydulieu();
          foreach (DataRow row in table.Rows)
          {
              if ((row[0].ToString().ToLower().CompareTo(nguoidung.Email.ToLower()) == 0))
              {
                  return 1;
              }
          }
          return 0;
      }
    }
}

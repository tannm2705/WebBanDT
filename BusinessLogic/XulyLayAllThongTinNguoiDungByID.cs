using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using DataAccess.Select;
using Common;
using System.Data;

namespace BusinessLogic
{
   public class XulyLayAllThongTinNguoiDungByID
    {

       private SqlDataSource _ketqua;
       public SqlDataSource ketqua
       {
           get { return _ketqua; }
           set { _ketqua = value; }
       }

   
       public void Thucthi( string MaKieuNguoiDung)
       {
           TruyXuatAllThongTinNguoiDungByID nguoidungID = new TruyXuatAllThongTinNguoiDungByID();
           ketqua = nguoidungID.LaydulieuAdmin( MaKieuNguoiDung);
       }

       private DataTable _table = new DataTable();

       public DataTable Table
       {
           get { return _table; }
           set { _table = value; }
       }
       private NguoiDung _nguoidung = new NguoiDung();

       public NguoiDung Nguoidung
       {
           get { return _nguoidung; }
           set { _nguoidung = value; }
       }

       public void Thuc_thi()
       {
           TruyXuatAllThongTinNguoiDungByID nguoidungID = new TruyXuatAllThongTinNguoiDungByID();
           nguoidungID.Nguoidung.Email = this.Nguoidung.Email;
           Table= nguoidungID.table_NguoiDung();
       }
    }
}

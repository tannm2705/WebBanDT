using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using DataAccess.Select;
using Common;

namespace BusinessLogic
{
   public class XulyThongKeSanPhamNguoiMua
    {

        DonHang _dh = new DonHang();

        public DonHang Dh
        {
            get { return _dh; }
            set { _dh = value; }
        }
        private SqlDataSource table_Giohang = new SqlDataSource();

        public SqlDataSource Table_Giohang
        {
            get { return table_Giohang; }
            set { table_Giohang = value; }
        }
       public void Thucthi()
       {
           ThongKeSanPhamNguoiMua giohang = new ThongKeSanPhamNguoiMua();
           giohang.Dh.MaDonHang = Dh.MaDonHang;
           Table_Giohang = giohang.Get_Giohang();
       }
    }
}

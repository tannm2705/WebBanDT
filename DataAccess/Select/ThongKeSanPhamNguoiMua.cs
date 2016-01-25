using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using Common;

namespace DataAccess.Select
{
   public class ThongKeSanPhamNguoiMua
    {
        private DonHang _dh = new DonHang();

        public DonHang Dh
        {
            get { return _dh; }
            set { _dh = value; }
        }

        public SqlDataSource Get_Giohang()
        {
            Ketnoi kn = new Ketnoi();
            SqlDataSource sql = new SqlDataSource();
            sql.ConnectionString = kn.ConnectionString();
            sql.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sql.SelectCommand = "ThongKeSPCuaNguoiMua";
            sql.SelectParameters.Add("MaDonHang",Dh.MaDonHang.ToString());
            return sql;
        }
    }
}

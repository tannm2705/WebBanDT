using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Delete
{
   public class XoaSanPham
    {
       private ThongTinSanPham _thongtinsp = new ThongTinSanPham();

        public ThongTinSanPham Thongtinsp
        {
            get { return _thongtinsp; }
            set { _thongtinsp = value; }
        }

        public void XoaDuLieu()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinSanPham_Delete";
            cmd.Parameters.Add("@MaSanPham", SqlDbType.VarChar).Value = Thongtinsp.MaSanPham;
            cmd.ExecuteNonQuery();
        }
    }
}

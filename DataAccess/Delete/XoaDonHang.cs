using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.Delete
{
   public class XoaDonHang
    {
        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }
        public void Delete_Donhang()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DonHang_Delete";
            cmd.Parameters.Add("@MaDonHang", SqlDbType.VarChar).Value = Donhang.MaDonHang;
            cmd.ExecuteNonQuery();
        }
    }
}

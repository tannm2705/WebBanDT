using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.SqlClient;
using System.Data;


namespace DataAccess.Update
{
    public class CapNhatDonHang
    {

        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }

        public void Update_Donhang()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DonHang_Update";
            cmd.Parameters.Add("@MaDonHang",SqlDbType.Int).Value=Donhang.MaDonHang;
            cmd.Parameters.Add("@NgayChuyen",SqlDbType.DateTime).Value=Donhang.NgayChuyen;
            cmd.Parameters.Add("@TinhTrang",SqlDbType.NVarChar).Value=Donhang.TinhTrang;
            cmd.ExecuteNonQuery();
        }
    }
}

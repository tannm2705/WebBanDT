using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Insert
{
   public class ThemDonHang
    {
        private DonHang _donhang = new DonHang();

        public DonHang Donhang
        {
            get { return _donhang; }
            set { _donhang = value; }
        }

        public void Them_DonHang()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DonHang_Insert";
            cmd.Parameters.Add("@Email",SqlDbType.VarChar).Value=Donhang.Email;
            cmd.Parameters.Add("@NgayDatHang",SqlDbType.DateTime).Value=Donhang.NgayDatHang;
            cmd.Parameters.Add("@NgayYeuCau",SqlDbType.DateTime).Value=Donhang.NgayYeuCau;
            //cmd.Parameters.Add("@NgayChuyen",SqlDbType.DateTime).Value=Donhang.NgayChuyen;
            cmd.Parameters.Add("@DiaChiNhan",SqlDbType.NVarChar).Value=Donhang.DiaChiNhan;
            cmd.ExecuteNonQuery();
        }
    }
}

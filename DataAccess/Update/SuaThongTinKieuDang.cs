using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common;

namespace DataAccess.Update
{
   
   public class SuaThongTinKieuDang
    {
        private KieuDang _kieudang = new KieuDang();

        public KieuDang Kieudang
        {
            get { return _kieudang; }
            set { _kieudang = value; }
        }

        public void SuaThongTin_KieuDang()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KieuDang_Update";
            cmd.Parameters.Add("@MaKieuDang",SqlDbType.VarChar).Value=Kieudang.MaKieuDang;
            cmd.Parameters.Add("@TenKieuDang",SqlDbType.NVarChar).Value=Kieudang.TenKieuDang;
            cmd.ExecuteNonQuery();
        }
    }
}

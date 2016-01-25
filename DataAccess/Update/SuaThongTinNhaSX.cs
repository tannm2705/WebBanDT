using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Update
{
   public class SuaThongTinNhaSX
    {
        NhaSX nsx = new NhaSX();

        public NhaSX Nsx
        {
            get { return nsx; }
            set { nsx = value; }
        }

        public void suathongtinNSX()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NhaSX_Update";
            cmd.Parameters.Add("@MaNSX",SqlDbType.VarChar).Value=Nsx.MaNSX;
            cmd.Parameters.Add("@TenNSX",SqlDbType.NVarChar).Value=Nsx.TenNSX;
            cmd.ExecuteNonQuery();
        }
    }
}

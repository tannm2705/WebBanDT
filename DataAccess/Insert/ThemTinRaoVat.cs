using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Insert
{
    public class ThemTinRaoVat
    {
        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }
        public void Them_TinRaoVat()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TinRaoVat_Insert";
            cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = Tinraovat.TieuDe;
            cmd.Parameters.Add("@Link", SqlDbType.VarChar).Value = Tinraovat.Link;
            cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = Tinraovat.NgayDang;
            cmd.ExecuteNonQuery();
        }
    }
}

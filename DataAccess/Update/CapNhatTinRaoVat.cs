using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Update
{
    public class CapNhatTinRaoVat
    {
        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }
        public void Update_TinRaoVat()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TinRaoVat_Update";
            cmd.Parameters.Add("@MaTin", SqlDbType.Int).Value = Tinraovat.MaTin;
            cmd.Parameters.Add("@TieuDe", SqlDbType.NVarChar).Value = Tinraovat.TieuDe;
            cmd.Parameters.Add("@Link", SqlDbType.VarChar).Value = Tinraovat.Link;
            cmd.Parameters.Add("@NgayDang", SqlDbType.DateTime).Value = Tinraovat.NgayDang;
            cmd.ExecuteNonQuery();
        }
    }
}

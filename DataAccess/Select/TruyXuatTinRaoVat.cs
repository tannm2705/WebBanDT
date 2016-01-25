using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Select
{
    public class TruyXuatTinRaoVat
    {
        TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }
        public DataTable GetTinRaoVat()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "TinRaoVat_SelectAll";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connect;
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

    }
}

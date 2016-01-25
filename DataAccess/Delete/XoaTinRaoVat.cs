using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Delete
{
   public class XoaTinRaoVat
    {
        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }
       public void Delete_TinRaoVat()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "TinRaoVat_Delete";
           cmd.Parameters.Add("@MaTin", SqlDbType.VarChar).Value = Tinraovat.MaTin;
           cmd.ExecuteNonQuery();
       }
    }
}

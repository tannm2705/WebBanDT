using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Select
{
    public class GetPass
    {
        private NguoiDung ngDung = new NguoiDung();
        public int flag { get; set; }
        public NguoiDung NgDung
        {
            get { return ngDung; }
            set { ngDung = value; }
        }

        public string Get_Pass()
        {
            string str="";
            Ketnoi kn = new Ketnoi();
            SqlConnection con = new SqlConnection(kn.ConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = "GetPassByEmail";
            cmd.Parameters.Add("@Email",SqlDbType.VarChar).Value=NgDung.Email;
            str = cmd.ExecuteScalar().ToString();
            return str;
        }
    }
}

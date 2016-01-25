using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Update
{
   public class SuaThongTinPhongCach
    {
        PhongCach _phongcach = new PhongCach();

        public PhongCach Phongcach
        {
            get { return _phongcach; }
            set { _phongcach = value; }
        }

        public void SuathongtinPhongcach()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PhongCach_Update";
            cmd.Parameters.Add("@MaPhongCach",SqlDbType.VarChar).Value=Phongcach.MaPhongCach;
            cmd.Parameters.Add("@TenPhongCach", SqlDbType.NVarChar).Value = Phongcach.TenPhongCach ;
            cmd.ExecuteNonQuery();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common;

namespace DataAccess.Insert
{
   public class ThemPhongCach
    {

       private PhongCach _phongcach;
       public PhongCach phongcach
       {
           get { return _phongcach; }
           set { _phongcach = value; }
       }
       public void Themdulieu()
       {
           Ketnoi connectString = new Ketnoi();
           SqlConnection connect = new SqlConnection(connectString.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "PhongCach_Insert";
           cmd.Parameters.Add("@MaPhongCach", SqlDbType.VarChar).Value = phongcach.MaPhongCach;
           cmd.Parameters.Add("@TenPhongCach", SqlDbType.NVarChar).Value = phongcach.TenPhongCach;
           cmd.ExecuteNonQuery();
       }
    }
}

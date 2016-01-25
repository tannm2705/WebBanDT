using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common;

namespace DataAccess.Insert
{
   public class ThemNhaSX
    {

       private NhaSX _nhasx;
       public NhaSX nhasx
       {
           get { return _nhasx; }
           set { _nhasx = value; }
       }

       public void Themdulieu()
       {
           Ketnoi connectString = new Ketnoi();
           SqlConnection connect = new SqlConnection(connectString.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "NhaSX_Insert";
           cmd.Parameters.Add("@MaNSX",SqlDbType.VarChar).Value=nhasx.MaNSX;
           cmd.Parameters.Add("@TenNSX",SqlDbType.NVarChar).Value=nhasx.TenNSX;
           cmd.ExecuteNonQuery();
       }
    }
}

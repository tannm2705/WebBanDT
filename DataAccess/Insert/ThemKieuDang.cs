using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common;


namespace DataAccess.Insert
{
   public class ThemKieuDang
    {

       private KieuDang _kieudang;
       public KieuDang kieudang
       {
           get { return _kieudang; }
           set { _kieudang = value; }
       }

       public void Themdulieu()
       {
           Ketnoi connectString = new Ketnoi();
           SqlConnection connect = new SqlConnection(connectString.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "KieuDang_Insert";
           cmd.Parameters.Add("@MaKieuDang", SqlDbType.VarChar).Value = kieudang.MaKieuDang;
           cmd.Parameters.Add("@TenKieuDang", SqlDbType.NVarChar).Value = kieudang.TenKieuDang;
           cmd.ExecuteNonQuery();
       }
    }
}

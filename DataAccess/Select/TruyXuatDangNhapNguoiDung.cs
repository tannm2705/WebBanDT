using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Select
{
   
   public class TruyXuatDangNhapNguoiDung
    {
       public DataTable Laydulieu()
       {
           DataTable dt = new DataTable();
           Ketnoi kn = new Ketnoi();
           SqlCommand cmd = new SqlCommand();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "DangNhap_Select";
           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           adapter.Fill(dt);

           return dt;
       }
    }
}

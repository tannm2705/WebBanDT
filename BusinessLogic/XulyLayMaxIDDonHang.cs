using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;

namespace BusinessLogic
{
   public class XulyLayMaxIDDonHang
    {

       public string LayID()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "DonHang_MaxID";
           string st = cmd.ExecuteScalar().ToString();
           return st;
       }
    }
}

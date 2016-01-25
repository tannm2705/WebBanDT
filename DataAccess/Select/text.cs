using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.Select
{
   public class text
    {
       Ketnoi kn = new Ketnoi();
       public string getstring()
       {
           SqlConnection con = new SqlConnection(kn.ConnectionString());
           con.Open();
           SqlCommand cmd = new SqlCommand("select MoTa from ThongTinSanPham where MaSanPham=41", con);
            string st=cmd.ExecuteScalar().ToString();
            return st;
       }
    }
}

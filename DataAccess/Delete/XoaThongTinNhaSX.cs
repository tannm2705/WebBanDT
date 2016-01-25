using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Delete
{
   public class XoaThongTinNhaSX
    {
        private NhaSX _nhasx = new NhaSX();

        public NhaSX Nhasx
        {
            get { return _nhasx; }
            set { _nhasx = value; }
        }
       public void XoaDuLieu()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "NhaSX_Delete";
           cmd.Parameters.Add("@MaNSX", SqlDbType.VarChar).Value = Nhasx.MaNSX;
           cmd.ExecuteNonQuery();
       }
    }
}

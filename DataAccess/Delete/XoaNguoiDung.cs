using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Common;

namespace DataAccess.Delete
{
   public class XoaNguoiDung
    {
        private NguoiDung _nguoidung = new NguoiDung();

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public void XoaDuLieu()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NguoiDung_Delete";
            cmd.Parameters.Add("@Email",SqlDbType.VarChar).Value=Nguoidung.Email;
            cmd.ExecuteNonQuery();
        }

    }
}

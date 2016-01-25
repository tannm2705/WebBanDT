using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Delete
{
   public class XoaThongTinPhongCach
    {
        private PhongCach _phcach = new PhongCach();

        public PhongCach Phcach
        {
            get { return _phcach; }
            set { _phcach = value; }
        }
        public void XoaDuLieu()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PhongCach_Delete";
            cmd.Parameters.Add("@MaPhongCach", SqlDbType.VarChar).Value = Phcach.MaPhongCach;
            cmd.ExecuteNonQuery();
        }
    }
}

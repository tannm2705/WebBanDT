using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Delete
{
  public  class XoaThongTinKieuDang
    {
        private KieuDang _kdang = new KieuDang();

        public KieuDang Kdang
        {
            get { return _kdang; }
            set { _kdang = value; }
        }
        
        public void XoaDuLieu()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KieuDang_Delete";
            cmd.Parameters.Add("@MaKieuDang", SqlDbType.VarChar).Value = Kdang.MaKieuDang;
            cmd.ExecuteNonQuery();
        }
    }
}

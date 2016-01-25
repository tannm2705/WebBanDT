using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Select
{
    public class SanPhamSearch
    {
        ThongTinSanPham _ttsanpham = new ThongTinSanPham();

        public ThongTinSanPham Ttsanpham
        {
            get { return _ttsanpham; }
            set { _ttsanpham = value; }
        }

        public DataTable ketqua()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = "SanPham_Search";
            cmd.Parameters.Add("@Search",SqlDbType.NVarChar).Value=Ttsanpham.TenSanPham;
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            SqlDataAdapter adpter = new SqlDataAdapter();
            adpter.SelectCommand = cmd;
            adpter.Fill(dt);
            return dt;
        }
    }
}

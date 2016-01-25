using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace DataAccess.Select
{
  public  class TruyXuatAllThongTinSanPham
    {

        public SqlDataSource Laydulieu()
        {
            SqlDataSource sqldata = new SqlDataSource();
            Ketnoi stringconnect = new Ketnoi();
            sqldata.ConnectionString = stringconnect.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "ThongTinSanPham_SelectAll";
            return sqldata;
        }

        public DataTable Lay_table()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinSanPham_SelectAll";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            return dt;
        }
    }
}

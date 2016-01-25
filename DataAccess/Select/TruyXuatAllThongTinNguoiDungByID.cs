using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Common;
namespace DataAccess.Select
{
   public class TruyXuatAllThongTinNguoiDungByID
    {
        private NguoiDung _nguoidung = new NguoiDung();

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        public SqlDataSource LaydulieuAdmin( string MaKieuNguoiDung)
        {
            SqlDataSource sqldata = new SqlDataSource();
            Ketnoi connectString = new Ketnoi();
            sqldata.ConnectionString = connectString.ConnectionString();
            sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
            sqldata.SelectCommand = "NguoiDung_SelectByMaKND";
            sqldata.SelectParameters.Add("MaKieuNguoiDung",MaKieuNguoiDung.ToString());
            return sqldata;
        }

        public DataTable table_NguoiDung()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = "NguoiDung_SelectEmail_Hoten";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Email",SqlDbType.VarChar).Value=this.Nguoidung.Email;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}

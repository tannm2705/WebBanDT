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
   public class TruyXuatThongTinSanPhamByID
    {
       private ThongTinSanPham _thongtinsanpham=new ThongTinSanPham();
       public ThongTinSanPham thongtinsanpham
       {
           get { return _thongtinsanpham; }
           set { _thongtinsanpham = value; }
       }

       public SqlDataSource Laydulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           Ketnoi connectString = new Ketnoi();
           sqldata.ConnectionString = connectString.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "ThongTinSanPham_SelectByID";
           sqldata.SelectParameters.Add("MaSanPham",thongtinsanpham.MaSanPham.ToString());
           return sqldata;
       }

       public DataTable table()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "ThongTinSanPham_SelectByID";
           cmd.Parameters.Add("@MaSanPham", SqlDbType.Int).Value = thongtinsanpham.MaSanPham;

           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           DataTable dt = new DataTable();
           adapter.Fill(dt);

           return dt;
       }
    }
}

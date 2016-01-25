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
   public class TruyXuatAllThongTinSanPhamByMaNSX
    {

       private ThongTinSanPham _MaNSX=new ThongTinSanPham();
       public ThongTinSanPham MaNSX
       {
           get { return _MaNSX; }
           set { _MaNSX = value; }
       }

       public DataTable table()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "ThongTinSanPham_SelectByMaNSX";
           cmd.Parameters.Add("@MaNSX", SqlDbType.VarChar).Value = this.MaNSX.MaNSX;
           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           DataTable dt = new DataTable();
           adapter.Fill(dt);
           connect.Close();
           return dt;
       }
    }
}

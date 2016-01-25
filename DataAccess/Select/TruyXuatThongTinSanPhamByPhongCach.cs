using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Select
{
   public class TruyXuatThongTinSanPhamByPhongCach
    {
       private ThongTinSanPham _thongtinsanpham=new ThongTinSanPham();
       public ThongTinSanPham thongtinsanpham
       {
           get { return _thongtinsanpham; }
           set { _thongtinsanpham = value; }
       }

       public DataTable table()
       {
           Ketnoi kn = new Ketnoi();
           SqlConnection connect = new SqlConnection(kn.ConnectionString());
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "ThongTinSanPham_SelectPC";
           cmd.Parameters.Add("@MaPhongCach",SqlDbType.VarChar).Value=thongtinsanpham.MaPhongCach;
           DataTable dt = new DataTable();
           SqlDataAdapter adapter = new SqlDataAdapter();
           adapter.SelectCommand = cmd;
           adapter.Fill(dt);

           return dt;
       }
    }
}

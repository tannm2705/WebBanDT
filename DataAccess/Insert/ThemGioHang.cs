using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;

namespace DataAccess.Insert
{
   public class ThemGioHang
    {
        private GioHang _giohang = new GioHang();

        public GioHang Giohang
        {
            get { return _giohang; }
            set { _giohang = value; }
        }

        public void Them_GioHang()
        {
            Ketnoi kn = new Ketnoi();
            SqlConnection connect = new SqlConnection(kn.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GioHang_Insert";
            cmd.Parameters.Add("@MaSanPham",SqlDbType.Int).Value=Giohang.MaSanPham;
            cmd.Parameters.Add("@MaDonHang",SqlDbType.Int).Value=Giohang.MaDonHang;
            cmd.Parameters.Add("@DonGia",SqlDbType.Int).Value=Giohang.DonGia;
            cmd.Parameters.Add("@SoLuong",SqlDbType.Int).Value=Giohang.SoLuong;
            cmd.Parameters.Add("@TongTien",SqlDbType.Int).Value=Giohang.TongTien;
            cmd.ExecuteNonQuery();
        }
    }
}

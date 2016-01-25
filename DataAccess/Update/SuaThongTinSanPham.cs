using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Update
{
   public class SuaThongTinSanPham
    {

       private ThongTinSanPham _ttsanpham = new ThongTinSanPham();
        public ThongTinSanPham ttsanpham
        {
            get { return _ttsanpham; }
            set { _ttsanpham = value; }
        }

        public void Suadulieu()
        {
            Ketnoi ketnoi = new Ketnoi();
            SqlConnection connect = new SqlConnection(ketnoi.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinSanPham_Update";
            cmd.Parameters.Add("@MaSanPham",SqlDbType.Int).Value=ttsanpham.MaSanPham;
            cmd.Parameters.Add("@MaNSX", SqlDbType.VarChar).Value = ttsanpham.MaNSX;
            cmd.Parameters.Add("@MaKieuDang", SqlDbType.VarChar).Value = ttsanpham.MaKieuDang;
            cmd.Parameters.Add("@MaPhongCach", SqlDbType.VarChar).Value = ttsanpham.MaPhongCach;
            cmd.Parameters.Add("@TenSanPham", SqlDbType.NVarChar).Value = ttsanpham.TenSanPham;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = ttsanpham.MoTa;
            cmd.Parameters.Add("@GiaSanPham", SqlDbType.Int).Value = ttsanpham.GiaSanPham;
            cmd.Parameters.Add("@ImageSP", SqlDbType.VarChar).Value = ttsanpham.ImageSP;
            cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ttsanpham.SoLuong;
            cmd.Parameters.Add("@TenHDH", SqlDbType.NVarChar).Value = ttsanpham.TenHDH;
            cmd.Parameters.Add("@RAM", SqlDbType.NVarChar).Value = ttsanpham.RAM;
            cmd.Parameters.Add("@Camera", SqlDbType.NVarChar).Value = ttsanpham.Camera;
            cmd.Parameters.Add("@Pin", SqlDbType.Int).Value = ttsanpham.Pin;
            cmd.ExecuteNonQuery();
        }
    }
}

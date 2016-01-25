using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.Update
{
   public class SuaThongTinNguoiDung
    {
        private NguoiDung _nguoidung=new NguoiDung();

        public NguoiDung Nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }

        public void Suathongtin()
        {
            Ketnoi ketnoi = new Ketnoi();
            SqlConnection connect = new SqlConnection(ketnoi.ConnectionString());
            connect.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "NguoiDung_Update";
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = Nguoidung.Email.ToString();
            cmd.Parameters.Add("@MatKhau",SqlDbType.VarChar).Value=Nguoidung.MatKhau.ToString();
            cmd.Parameters.Add("@HoTen",SqlDbType.NVarChar).Value=Nguoidung.HoTen.ToString();
            cmd.Parameters.Add("@DiaChi",SqlDbType.NVarChar).Value=Nguoidung.DiaChi.ToString();
            cmd.Parameters.Add("@SoDT", SqlDbType.VarChar).Value = Nguoidung.SoDT.ToString();
            cmd.Parameters.Add("@SoFax",SqlDbType.VarChar).Value=Nguoidung.SoFax.ToString();
            cmd.Parameters.Add("@MaKieuNguoiDung",SqlDbType.Int).Value=Nguoidung.MaKieuNguoiDung;
            cmd.ExecuteNonQuery();
        }
    }
}

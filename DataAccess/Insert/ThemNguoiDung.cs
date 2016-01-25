using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Insert
{

   public class ThemNguoiDung
    {

       private NguoiDung _nguoidung=new NguoiDung();
       public NguoiDung nguoidung
       {
           get { return _nguoidung; }
           set { _nguoidung = value; }
       }

       public void Themdulieu()
       {
           Ketnoi ketnoi = new Ketnoi();
           SqlConnection connect = new SqlConnection(ketnoi.ConnectionString());
           connect.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = connect;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "NguoiDung_Insert";
           cmd.Parameters.Add("@MaKieuNguoiDung", SqlDbType.Int).Value = nguoidung.MaKieuNguoiDung;
           cmd.Parameters.Add("@HoTen",SqlDbType.NVarChar).Value=nguoidung.HoTen;
           cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nguoidung.DiaChi;
           cmd.Parameters.Add("@SoDT", SqlDbType.VarChar).Value = nguoidung.SoDT;
           cmd.Parameters.Add("@SoFax", SqlDbType.VarChar).Value = nguoidung.SoFax;
           cmd.Parameters.Add("@Email",SqlDbType.VarChar).Value=nguoidung.Email;
           cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = nguoidung.MatKhau;
           cmd.ExecuteNonQuery();
       }
    }
}

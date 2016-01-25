using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Select;
using BusinessLogic;
using Common;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebBanDT.Web
{
    public partial class SanPham : System.Web.UI.MasterPage
    {
        private string email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
        
                if (Session.Contents["TrangThaiUse"].ToString().CompareTo("DaDangNhap") == 0)
                { 
                    multiview1.ActiveViewIndex = 1;
                    lbwellcome.Text = "Wellcome " + Session.Contents["use"].ToString();
                    this.HienThiAnh();
                }
                else
                {
                    multiview1.ActiveViewIndex = 0;
                }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Kiemtradangnhap();
        }

        public void Kiemtradangnhap()
        {
            XuLyKiemTraThongTinDangNhap login = new XuLyKiemTraThongTinDangNhap();
            NguoiDung nguoidung = new NguoiDung();
       //     nguoidung.Email = txtEmail.Text;
        //    nguoidung.MatKhau = txtMatKhau.Text;
            login.nguoidung = nguoidung;
            if (login.Thucthi() == 2)
            {

                Session.Contents["TrangThaiUse"]= "DaDangNhap";
                lbThongBao.Text = "Đăng nhập thành công";
        //        email= txtEmail.Text;
                Session.Contents["use"] = nguoidung.Email.ToString();
                XulyLayAllThongTinNguoiDungByID use_id = new XulyLayAllThongTinNguoiDungByID();
                use_id.Nguoidung.Email = nguoidung.Email;
                use_id.Thuc_thi();
                DataTable dt = use_id.Table;
                Session.Contents["TaiKhoan"] = dt;
                Response.Redirect("ChuyenHuong.aspx");
            }
            else
            {
                lbThongBao.Text = "Đang nhập thật bại";
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Contents["TrangThaiUse"] = "ChuaDangNhap";
            multiview1.ActiveViewIndex = 0;
            ((DataTable)Session.Contents["TaiKhoan"]).Clear();
            Response.Redirect("SanPham.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Contents["Search"] = txt_Search.Text;
            Response.Redirect("Search.aspx?");
        }

        protected void btnTimKiemNangCao_Click(object sender, EventArgs e)
        {
            Response.Redirect("TimKiemNangCao.aspx");
        }

        protected void HienThiAnh()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select ImgUrl from UserImg where Email = ('" + Session.Contents["use"].ToString() + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dlIgmUser.DataSource = cmd.ExecuteReader();
            dlIgmUser.DataBind();
            con.Close();
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Select;
using BusinessLogic;
using Common;
using System.Data;

namespace WebBanDT.Controler
{
    public partial class DangNhap : System.Web.UI.UserControl
    {
        private string email = "";
        protected void Page_Load(object sender, EventArgs e)
        {
                    
                if (Session.Contents["TrangThaiUse"].ToString().CompareTo("DaDangNhap") == 0)
                { 
                    multiview1.ActiveViewIndex = 1;
                   // lbwellcome.Text = "Wellcome " + Session.Contents["use"].ToString();
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
            nguoidung.Email = txtEmail.Text;
            nguoidung.MatKhau = txtMatKhau.Text;
            login.nguoidung = nguoidung;
            if (login.Thucthi() == 2)
            {

                Session.Contents["TrangThaiUse"]= "DaDangNhap";
                lbThongBao.Text = "Đăng nhập thành công";
                email= txtEmail.Text;
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
        }
    }
}
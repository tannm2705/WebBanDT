using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Common;
using BusinessLogic;

namespace WebBanDT.Admin
{
    public partial class Dangnhapadmin : System.Web.UI.Page
    {
        private NguoiDung nguoidung1 = new NguoiDung();

        public NguoiDung Nguoidung1
        {
            get { return nguoidung1; }
            set { nguoidung1 = value; }
        }

        private NguoiDung nguoidung2 = new NguoiDung();

        public NguoiDung Nguoidung2
        {
            get { return nguoidung2; }
            set { nguoidung2 = value; }
        }
        XuLyKiemTraThongTinDangNhap ktLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
           // this.Loadgridview();
            ktLogin = new XuLyKiemTraThongTinDangNhap();
            labelThongbao.Text = "";
            txtEmail.Focus();
        }
        
        protected void DangNhap_Click(object sender, EventArgs e)
        {
            ktLogin.nguoidung.Email = txtEmail.Text;
            ktLogin.nguoidung.MatKhau = txtPass.Text;
            if (ktLogin.Thucthi() == 1)
            {
                labelThongbao.Text = "Đăng nhập administrator thành công";
                Session.Contents["TrangThai"] = "DaDangNhap";
                txtEmail.Text= "";
                txtPass.Text= "";

                txtEmail.Enabled = false;
                txtPass.Enabled = false;
                btnDangNhap.Enabled = false;
                btnHuyBo.Enabled = false;
            }
            else
            {
                labelThongbao.Text = "Đăng nhập thất bại";
                txtEmail.Text = "";
                txtPass.Text = "";
            }
        }
        protected void HuyBo_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TrangChu.aspx");
        }

        protected void DangXuat_Click(object sender, EventArgs e)
        {
            Session.Contents["TrangThai"] = "ChuaDangNhap";
            Response.Redirect("Dangnhapadmin.aspx");
            txtEmail.Enabled = false;
            txtPass.Enabled = false;
            btnDangNhap.Enabled = false;
            btnHuyBo.Enabled = false;

        }


      
    }
}
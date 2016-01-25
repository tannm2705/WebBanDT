using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using BusinessLogic;


namespace WebBanDT
{
    public partial class DangKy : System.Web.UI.Page
    {
        XulyThemNguoiDung insert_nguoidung;
        private NguoiDung _nguoidung=new NguoiDung();//phải khởi tạo để gán giá tri

        public NguoiDung nguoidung
        {
            get { return _nguoidung; }
            set { _nguoidung = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
                insert_nguoidung = new XulyThemNguoiDung();
                multiview1.ActiveViewIndex = 0;
            
        }

        
        public void Dangky()
        {
            nguoidung.Email =txtEmail.Text;
            nguoidung.MatKhau = txtMatkhau.Text;
            nguoidung.HoTen = txtHoTen.Text;
            nguoidung.DiaChi = txtDiaChi.Text;
            nguoidung.SoDT = txtSoDT.Text;
            nguoidung.SoFax = txtSofax.Text;
            nguoidung.MaKieuNguoiDung = 2;
            insert_nguoidung.nguoidung = this.nguoidung;
            insert_nguoidung.Thucthi();
        }

        protected void DangKy_Click(object sender, EventArgs e)
        {
            
            
             try
                {
                    this.Dangky();
                    multiview1.ActiveViewIndex = 1;
                }
                catch (Exception) { lbtest.Text = "Tài Khoản Đã Tồn Tại"; }
            
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using BusinessLogic;

namespace WebBanDT.Admin
{
    public partial class ThemSanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["TrangThai"].ToString().CompareTo("ChuaDangNhap") == 0)
            {
                Response.Redirect("~/Admin/Dangnhapadmin.aspx");
            }
            if (!IsPostBack)
            {
                txtTenSanPham.Focus();
                this.LoadDropdown();
            }
        }

        private void LoadDropdown()
        {
            XulyLayAllthongtinNhaSX nhasx = new XulyLayAllthongtinNhaSX();
            XulyLayAllThongTinPhongCach phongcach = new XulyLayAllThongTinPhongCach();
            XulyLayAllThongTinKieuDang kieudang = new XulyLayAllThongTinKieuDang();

            try
            {
                nhasx.Thucthi();
                phongcach.Thucthi();
                kieudang.Thucthi();
            }
            catch
            {
                lbThongbao.Text = "Lỗi thực thi";
            }

            DropdownMaNSX.DataTextField = "TenNSX";
            DropdownMaNSX.DataValueField = "MaNSX";
            DropdownMaNSX.DataSource = nhasx.Ketqua;
            DropdownMaNSX.DataBind();

            DropdownMaKieuDang.DataTextField = "TenKieuDang";
            DropdownMaKieuDang.DataValueField = "MaKieuDang";
            DropdownMaKieuDang.DataSource = kieudang.ketqua;
            DropdownMaKieuDang.DataBind();

            DropdownPhongCach.DataTextField = "TenPhongCach";
            DropdownPhongCach.DataValueField = "MaPhongCach";
            DropdownPhongCach.DataSource = phongcach.ketqua;
            DropdownPhongCach.DataBind();
        }
        private string Laylink_file_image()
        {
            string tenfile = "";
            string duongdan = "";
            string duongdantuongdoi = "";
            if (FileUpload1.HasFile == true)
            {
                tenfile = FileUpload1.FileName;
                duongdan = Server.MapPath("~/imagesDT/" + tenfile);
                FileUpload1.SaveAs(duongdan);

                duongdantuongdoi = "~/imagesDT/" + tenfile;
            }
            return duongdantuongdoi;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                XulyThemSanPhamMoi themsanpham = new XulyThemSanPhamMoi();
                ThongTinSanPham ttsanpham = new ThongTinSanPham();
                string linkimage = this.Laylink_file_image();

                ttsanpham.MaNSX = DropdownMaNSX.SelectedItem.Value;
                ttsanpham.MaKieuDang = DropdownMaKieuDang.SelectedItem.Value;
                ttsanpham.MaPhongCach = DropdownPhongCach.SelectedItem.Value;

                ttsanpham.TenSanPham = txtTenSanPham.Text;
                ttsanpham.MoTa = txtMoTaSanPham.Text;
                ttsanpham.GiaSanPham = Convert.ToInt32(txtGiaSanPham.Text);
                ttsanpham.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                ttsanpham.TenHDH = DropDownList1.SelectedItem.Value;
                ttsanpham.RAM = txtRAM.Text;
                ttsanpham.Camera = txtCamera.Text;
                ttsanpham.Pin = Convert.ToInt32(txtPin.Text);
                ttsanpham.ImageSP = linkimage.ToString();
                themsanpham.ttsanpham = ttsanpham;

                themsanpham.Thucthi();
                txtTenSanPham.Focus();

                // lbThongbao.Text = "Không thêm được";
            }
        }

        protected void btnHuybo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
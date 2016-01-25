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
    public partial class SuaThongTinSanPham : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (Session.Contents["TrangThai"].ToString() == "ChuaDangNhap")
                {
                    Response.Redirect("~/Admin/Dangnhapadmin.aspx");
                }
                if (!IsPostBack)
                {
                    this.LoadDropdown();
                    this.HienthiSPTheoMa();
                }
            }
        }
        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {

                ThongTinSanPham ttsanpham = new ThongTinSanPham();
                XulySuaThongTinSanPham editSp = new XulySuaThongTinSanPham();
                string linkimage = this.Laylink_file_image();

                ttsanpham.MaSanPham = int.Parse(Request.QueryString.Get("MaSanPham"));

                ttsanpham.MaNSX = DropdownMaNSX.SelectedItem.Value;
                ttsanpham.MaKieuDang = DropdownMaKieuDang.SelectedItem.Value;
                ttsanpham.MaPhongCach = DropdownPhongCach.SelectedItem.Value;

                ttsanpham.TenSanPham = txtTenSanPham.Text;
                ttsanpham.MoTa = txtMoTaSanPham.Text;
                ttsanpham.GiaSanPham = Convert.ToInt32(txtGiaSanPham.Text);
                ttsanpham.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                ttsanpham.TenHDH = txtHDH.Text;
                ttsanpham.RAM = txtRAM.Text;
                ttsanpham.Camera = txtCamera.Text;
                ttsanpham.Pin = Convert.ToInt32(txtPin.Text);
                ttsanpham.ImageSP = Label1.Text;
                if (FileUpload1.HasFile == true)
                {
                    ttsanpham.ImageSP= this.Laylink_file_image();
                }

                editSp.Thongtinsanpham = ttsanpham;
                try
                {
                    editSp.Thucthi();

                    lbThongbao.Text= "sửa sảnh phẩm thành công";
                }
                catch
                {
                    lbThongbao.Text = "Không sửa được";
                }
            }
        }

        protected void btnHuybo_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("SanPham.aspx");
            }
            catch { lbThongbao.Text = "Lỗi "; }
        }

        

        public void HienthiSPTheoMa()
        {
            ThongTinSanPham sp = new ThongTinSanPham();
            sp.MaSanPham = int.Parse(Request.QueryString.Get("MaSanPham"));
            XulyLayThongTinSanPhamByID SanphamID = new XulyLayThongTinSanPhamByID();
            SanphamID.thongtinsanpham.MaSanPham = sp.MaSanPham;
            try
            {
                SanphamID.Thucthi();

                DropdownMaNSX.SelectedIndex = DropdownMaNSX.Items.IndexOf(DropdownMaNSX.Items.FindByText(SanphamID.thongtinsanpham.Nhasx.TenNSX));
                DropdownPhongCach.SelectedIndex = DropdownPhongCach.Items.IndexOf(DropdownPhongCach.Items.FindByText(SanphamID.thongtinsanpham.Phongcach.TenPhongCach));
                DropdownMaKieuDang.SelectedIndex = DropdownMaKieuDang.Items.IndexOf(DropdownMaKieuDang.Items.FindByText(SanphamID.thongtinsanpham.Kieudang.TenKieuDang));
                txtTenSanPham.Text = SanphamID.thongtinsanpham.TenSanPham;
                txtMoTaSanPham.Text = SanphamID.thongtinsanpham.MoTa;
                txtGiaSanPham.Text = SanphamID.thongtinsanpham.GiaSanPham.ToString();
                txtSoLuong.Text = SanphamID.thongtinsanpham.SoLuong.ToString();
                txtHDH.Text = SanphamID.thongtinsanpham.TenHDH;
                txtRAM.Text = SanphamID.thongtinsanpham.RAM;
                txtCamera.Text = SanphamID.thongtinsanpham.Camera;
                txtPin.Text = SanphamID.thongtinsanpham.Pin.ToString();
                Label1.Text = SanphamID.thongtinsanpham.ImageSP;
                image1.ImageUrl = SanphamID.thongtinsanpham.ImageSP;
                
            }
            catch
            { lbThongbao.Text = "Lỗi! không lấy được DL"; }
            
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

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                XulyXoaThongTinSP delete_sp = new XulyXoaThongTinSP();
                delete_sp.ThongtinSP.MaSanPham = int.Parse(Request.QueryString.Get("MaSanPham"));
                try
                {
                    delete_sp.Thucthi();
                    lbThongbao.Text = "Xóa sản phẩm thành công";
                }
                catch { lbThongbao.Text = "Lỗi không thể xóa"; }
            }
        }
    }
}
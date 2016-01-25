using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Common;
using BusinessLogic;

namespace WebBanDT
{
    public partial class ThongTinCaNhan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable ddt = new DataTable();
                try
                {
                    ddt = (DataTable)Session.Contents["TaiKhoan"]; // Kiểm tra session đăng nhập
                    lbTenTK.Text = ddt.Rows[0]["Email"].ToString();

                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select ImgUrl, HoTen from UserImg a, NguoiDung b where a.Email = b.Email and a.Email = ('" + lbTenTK.Text + "')");
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    dlIgmUser.DataSource = cmd.ExecuteReader();
                    dlIgmUser.DataBind();
                    con.Close();
                    this.FillHoTen_a();
                    this.FillHoTen_b();
                    this.FillDiaChi();
                    this.HienSoDT();
                    this.HienSoFax();
                    MultiView2.ActiveViewIndex = 1;
                }
                catch
                {
                    MultiView2.ActiveViewIndex = 0;
                    return;
                }
            }
        }

        //----------------Hien Thi Du Lieu--------------------//
        protected void FillHoTen_a()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select HoTen from NguoiDung where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
            con.Close();
        }

        protected void FillHoTen_b()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select HoTen from NguoiDung where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataList2.DataSource = cmd.ExecuteReader();
            DataList2.DataBind();
            con.Close();
        }

        protected void FillDiaChi()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select DiaChi from NguoiDung where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dlDiaChi.DataSource = cmd.ExecuteReader();
            dlDiaChi.DataBind();
            con.Close();
        }

        protected void HienSoDT()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select SoDT from NguoiDung where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dlSoDT.DataSource = cmd.ExecuteReader();
            dlSoDT.DataBind();
            con.Close();
        }

        protected void HienSoFax()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select SoFax from NguoiDung where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dlSoFax.DataSource = cmd.ExecuteReader();
            dlSoFax.DataBind();
            con.Close();
        }


        protected void btDoiTen_Click(object sender, EventArgs e)
        {
            MultiView2.ActiveViewIndex = 3;
        }

        //------------Thay Doi Ho Ten-------------------------//

        protected void btXacNhanTen_Click(object sender, EventArgs e)
        {
            string Email = lbTenTK.Text;
            string newName = txtHoTenNew.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update NguoiDung set HoTen = ('" + newName + "') where Email = ('" + Email + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("ThongTinCaNhan.aspx");
        }

        protected void btMatKhau_Click(object sender, EventArgs e)
        {
            MultiView2.ActiveViewIndex = 2;
        }

        //---------------Thay Doi Mat Khau----------------------//
        protected void btXacNhanMK_Click(object sender, EventArgs e)
        {
            string MatKhauMoi_1 = txtMKNew1.Text;
            string MatKhauMoi_2 = txtMKNew2.Text;
            if (MatKhauMoi_1 == MatKhauMoi_2)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("update NguoiDung set MatKhau = ('" + MatKhauMoi_1 + "') where Email = ('" + lbTenTK.Text + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                lbError2.Text = "Nhập Đúng";
                lbThongBao.Text = "Bạn đã đổi mật khẩu thành công";
            }
            else lbError2.Text = "Nhập sai mật khẩu";
        }

        //--------------Thay Doi Anh Dai Dien-------------------------//
        protected void btUpDate_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/UserImg/") + FileUpload1.FileName);
                string FilePath = "~/UserImg/";
                string FileName = FileUpload1.FileName;
                string File = FilePath + FileName;

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserImg (ImgUrl, Email) values ('" + File + "','" + lbTenTK.Text + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else lbThongBao1.Text = "Bạn chưa chọn file ảnh";

            Response.Redirect("ThongTinCaNhan.aspx");
        }

        //-------------Doi Dia Chi---------------------//
        protected void btDoiDiaChi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Visible = true;
            btDongY.Visible = true;
            btDoiDiaChi.Visible = false;
            btHuy.Visible = true;
        }

        protected void btDongY_Click(object sender, EventArgs e)
        {
            string DiaChi = txtDiaChi.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update NguoiDung set DiaChi = ('" + DiaChi + "') where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ThongTinCaNhan.aspx");
        }

        protected void btHuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinCaNhan.aspx");
        }

        //------------- Doi So Dien Thoai --------------//
        protected void btChangeSDT_Click(object sender, EventArgs e)
        {
            txtSoDT.Visible = true;
            btXacNhan.Visible = true;
            btCancel.Visible = true;
            btChangeSDT.Visible = false;
        }

        protected void btXacNhan_Click(object sender, EventArgs e)
        {
            string SoDT = txtSoDT.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update NguoiDung set SoDT = ('" + SoDT + "') where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ThongTinCaNhan.aspx");
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinCaNhan.aspx");
        }

        //---------------Doi So Fax------------------//
        protected void btChangeSoFax_Click(object sender, EventArgs e)
        {
            txtSoFax.Visible = true;
            btCancelSoFax.Visible = true;
            btXacNhanSoFax.Visible = true;
            btChangeSoFax.Visible = false;
        }

        protected void btXacNhanSoFax_Click(object sender, EventArgs e)
        {
            string SoFax = txtSoFax.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update NguoiDung set SoFax = ('" + SoFax + "') where Email = ('" + lbTenTK.Text + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ThongTinCaNhan.aspx");
        }

        protected void btCancelSoFax_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThongTinCaNhan.aspx");
        }
    }
}
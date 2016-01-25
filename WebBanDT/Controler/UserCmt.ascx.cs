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

namespace WebBanDT.Controler
{
    public partial class UserCmt : System.Web.UI.UserControl
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            //LbThongbao.Text = "Hãy thể hiện bạn là 1 người văn hóa trong bình luận của mình!";
            this.HienThiBinhLuan();
            if (!IsPostBack)
            {
                BindRatingControl();
                DataTable ddt = new DataTable();

                try
                {
                    ddt = (DataTable)Session.Contents["TaiKhoan"]; // Kiểm tra session đăng nhập
                    lbEmail.Text = ddt.Rows[0]["Email"].ToString();
                    lbHoTen.Text = ddt.Rows[0]["HoTen"].ToString();
                    btFollow.Enabled = true;
                    // Hiện ảnh ở khung comment
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select HoTen, ImgUrl from NguoiDung b, UserImg c where b.Email = c.Email and c.Email = ('"+lbEmail.Text+"')");
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    dlComment.DataSource = cmd.ExecuteReader();
                    dlComment.DataBind();
                    con.Close();
                    btnPost.Enabled = false;
                    this.KiemTraMuaHang();
                    this.KiemTraTheoDoi();
                }

                catch
                {
                //    LbThongbao.Text = "Bạn chưa đăng nhập";
                    btnPost.Enabled = false;
                    btFollow.Enabled = false;
                    txtCmt.Text = "Bạn chưa mua hàng...";
                    return;
                }
            }
        }

        protected void HienThiBinhLuan()
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString();
            string ConnectionString = "Data Source=WIN-K2N35QVHMHB;Initial Catalog=WebBanDT;Integrated Security=True";
            string SqlCmd = "select HoTen, Comment, ImgUrl from UserComment a, NguoiDung b, UserImg c where a.Email = b.Email and b.Email = c.Email and MaSanPham = ('" + MaSanPham + "')";
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(SqlCmd, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "UserComment");

                CollectionPager1.PageSize = 3; // Phân trang cho CollectionPagger... PageSize = 3
                CollectionPager1.DataSource = ds.Tables["UserComment"].DefaultView; 
                CollectionPager1.BindToControl = dlThongTinCmt;
                dlThongTinCmt.DataSource = CollectionPager1.DataSourcePaged;
                dlThongTinCmt.DataBind();
            }
            catch (Exception) { }
            finally
            {
                conn.Close();
            }
        }

        //-----------------Đăng bình luận-----------------------//
        protected void btnPost_Click(object sender, EventArgs e)
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString(); // Lấy giá trị của mã sản phẩm trên thanh url
            int MaSP = Convert.ToInt32(MaSanPham);      // Chuyển MaSanPham thành dạng int
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            string Comment = txtCmt.Text;
            string Email = lbEmail.Text;
            if (txtCmt.Text == "")
            {
                LbThongbao.Text = "Bạn chưa nhập gì cả";
            }
            else
            {
               // LbThongbao.Text = "Bình luận thành công! Bạn hãy Load lại trang để xem bình luận của mình";
                SqlCommand cmd = new SqlCommand("Insert into UserComment (Email, Comment, MaSanPham) values ('" + Email + "','" + Comment + "','" + MaSP + "');");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            con.Close();
            Response.Redirect("ChiTietSanPham.aspx?MaSanPham="+MaSanPham+"");
        }

        //---------------Theo dõi sản phẩm------------------------//
        protected void btFollow_Click(object sender, EventArgs e)
        {
            string Email = lbEmail.Text;
            string MaSanPham = Request.QueryString["MaSanPham"].ToString(); // Lấy giá trị của mã sản phẩm trên thanh url
            int MaSP = Convert.ToInt32(MaSanPham);      // Chuyển MaSanPham thành dạng int
            
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into FollowingProduct values ('"+MaSanPham+"','"+Email+"')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ChiTietSanPham.aspx?MaSanPham=" + MaSanPham + "");
        }

        //-----------------------Rating code------------------------------//

        protected void RatingControlChanged(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RatingDetails(Rate, MaSanPham)values(@Rating, '"+MaSanPham+"')", con);
            cmd.Parameters.AddWithValue("@Rating", ratingControl.CurrentRating);
            cmd.ExecuteNonQuery();
            con.Close();
            BindRatingControl();
        }

        protected void BindRatingControl()
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString();
            int total = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Rate from RatingDetails where MaSanPham = ('"+MaSanPham+"')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dt.Rows[i][0].ToString());
                }
                int average = total / (dt.Rows.Count);
                ratingControl.CurrentRating = average;
                lbltxt.Text = dt.Rows.Count + " người đã bình chọn sản phẩm này";
            }
        }


        //---------------------Kiểm tra xem User đã mua hàng chưa------------------//
        protected void KiemTraMuaHang()
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString(); // Lấy giá trị của mã sản phẩm trên thanh url
            string Email = lbEmail.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Email from DonHang a, GioHang b where b.MaDonHang = a.MaDonHang and b.MaSanPham = ('" + MaSanPham + "') and a.Email = ('" + Email + "')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                btnPost.Enabled = true;
                LbThongbao.Text = "Bạn đã mua sản phẩm này";
            }
            else
            {
                btnPost.Enabled = false;
                LbThongbao.Text = "Bạn chưa mua sản phẩm này";
                txtCmt.Text = "Bạn chưa mua hàng...";
            }
        }

        //---------------Kiểm tra User có đang theo dõi sản phẩm hay không------------------//
        protected void KiemTraTheoDoi()
        {
            string MaSanPham = Request.QueryString["MaSanPham"].ToString(); // Lấy giá trị của mã sản phẩm trên thanh url
            string Email = lbEmail.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FollowingProduct where Email = ('"+Email+"') and MaSanPham = ('"+MaSanPham+"')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                btFollow.Text = "Đang theo dõi";
                btFollow.Enabled = false;
            }
            else
            {
                btFollow.Enabled = true;
            }
        }
        //-----------------------------------------------------------//

    }
}
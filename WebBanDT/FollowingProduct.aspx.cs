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
    public partial class FollowingProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               DataTable ddt=new DataTable();

               try
               {
                   ddt = (DataTable)Session.Contents["TaiKhoan"]; // Kiểm tra session đăng nhập
                   lbHoTen.Text = ddt.Rows[0]["HoTen"].ToString();
                   string Email = ddt.Rows[0]["Email"].ToString();

                   SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                   con.Open();
                   SqlCommand cmd = new SqlCommand("select * from ThongTinSanPham a, NguoiDung b, FollowingProduct c where a.MaSanPham = c.MaSanPham and b.Email = c.Email and b.Email = ('"+Email+"')");
                   cmd.Connection = con;
                   cmd.ExecuteNonQuery();
                   DataList1.DataSource = cmd.ExecuteReader();
                   DataList1.DataBind();
                   con.Close();

                   MultiView1.ActiveViewIndex = 1;
               }

               catch
               {
                   MultiView1.ActiveViewIndex = 0;
                   return;
               }
            }
        }

        //-------------Hàm lấy giá trị từ label trong datalist-------------//

       protected void Item_Command(Object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                string MaSanPham = ((Label)item.FindControl("lbMaSanPham")).Text;

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from FollowingProduct where MaSanPham = ('" + MaSanPham + "')");
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("FollowingProduct.aspx");
              }
        }
    }
}
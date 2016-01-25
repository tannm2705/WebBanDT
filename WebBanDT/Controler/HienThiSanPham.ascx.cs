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
    public partial class HienThiSanPham : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string FromGia = ddFrom.SelectedItem.Value;
            string ToGia = ddTo.SelectedItem.Value;
            string HangSanXuat = ddHangSanXuat.SelectedItem.Value;
            string HeDieuHanh = ddHeDieuHanh.SelectedItem.Value;
            string KieuDang = ddKieuDang.SelectedItem.Value;
            string MayAnh = ddMayAnh.SelectedItem.Value;
            LbThongBao.Text = "Kết quả tìm kiếm";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();

            string cmd = "Select * from ThongTinSanPham";
            if (FromGia != "0" && ToGia != "0")
            {
                {
                    cmd += " where GiaSanPham between ('" + FromGia + "') and ('" + ToGia + "')";
                    if (HangSanXuat != "00")
                    {
                        cmd += " and MaNSX = ('" + HangSanXuat + "')";
                    }
                    if (HeDieuHanh != "0")
                    {
                        cmd += " and TenHDH like ('%" + HeDieuHanh + "%')";
                    }
                    if (KieuDang != "KD0")
                    {
                        cmd += " and MaKieuDang = ('" + KieuDang + "')";
                    }
                    if (MayAnh != "0")
                    {
                        cmd += " and Camera like ('%" + MayAnh + "%')";
                    }
                }
                SqlCommand ThucThiLenh = new SqlCommand(cmd, con);
                SqlDataReader reader = ThucThiLenh.ExecuteReader();
                datalist1.DataSource = reader;
                datalist1.DataBind();
                con.Close();
            }
            else if (FromGia == "0" && ToGia == "0")
            {
                LbThongBao.Text = "Bạn chưa chọn mức giá!";
            }
        }
    }
}
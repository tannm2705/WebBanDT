using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using BusinessLogic;

namespace WebBanDT
{
    public partial class ThemGioHang : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session.Contents["TrangThaiUse"].ToString() == "ChuaDangNhap")
                {
                    Response.Redirect("GioHang.aspx");
                }
                else
                {
                    bool kiemtra = false;
                    int masp = int.Parse(Request.QueryString.Get("MaSanPham").ToString());
                    dt = (DataTable)Session["Cart"];
                    XulyLayTen_GiaSanPham name_cost = new XulyLayTen_GiaSanPham();
                    name_cost.Thongtinsanpham.MaSanPham = masp;
                    name_cost.Thucthi();
                    string tensp = name_cost.LaytenSP();
                    int giasp = int.Parse(name_cost.LayGiaSP().ToString());
                    if (dt.Rows.Count != 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {

                            if (int.Parse(dr[0].ToString()) == masp)
                            {
                                dr[3] = Convert.ToInt32(dr[3].ToString()) + 1;
                                dr[4] = Convert.ToInt32(dr[2].ToString()) * Convert.ToInt32(dr[3].ToString());
                                kiemtra = true;
                            }
                        }
                    }
                    if (kiemtra == false)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = masp;
                        dr[1] = tensp;
                        dr[2] = giasp;
                        dr[3] = 1;
                        dr[4] = Convert.ToInt32(dr[2].ToString()) * (Convert.ToInt32(dr[3].ToString()));
                        dt.Rows.Add(dr);
                        Session["Cart"] = dt;
                    }

                    Response.Redirect("SanPham.aspx");
                }
            }
        }
    }
}
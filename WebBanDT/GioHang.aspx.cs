using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Common;
using BusinessLogic;
using System.Data.SqlClient;
using System.Configuration;

namespace WebBanDT
{
    public partial class GioHang : System.Web.UI.Page
    {
        public String url_checkout = "https://www.nganluong.vn/advance_payment.php"; //check out nganluong
        public String url_checkout_baokim = "https://www.baokim.vn/payment/order/version11"; //check out baokim

        DataTable dttable = new DataTable();
        int tam = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               DataTable ddt=new DataTable();

               try
               {
                   ddt = (DataTable)Session.Contents["TaiKhoan"];
                   lbEmail.Text = ddt.Rows[0]["Email"].ToString();
                   lbHoTen.Text = ddt.Rows[0]["HoTen"].ToString();
                   lbNgayDatHang.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
               }

               catch { multiview1.ActiveViewIndex = 2; return; }
               
                DataTable dt = new DataTable();
                dt = (DataTable)Session["Cart"];
                if (dt.Rows.Count == 0)
                {
                    LbThongbao.Text = "Bạn chưa mua mặt hàng nào";
                    multiview1.ActiveViewIndex = 0;
                }
                else
                {
                    this.Load_gridview();
                    Total();
                    multiview1.ActiveViewIndex = 0;   
                }
            }
        }

        private void Load_gridview()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["Cart"];
            grv_GioHang.DataSource= dt;
            grv_GioHang.DataBind();
        }

        public void Total()
        {

            DataTable dt = new DataTable();
            dt = (DataTable)Session["Cart"];
            int Tongtien = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Tongtien +=int.Parse(dr[4].ToString());
            }
           grv_GioHang.FooterRow.Cells[3].Text = "Tổng tiền:"+Tongtien.ToString("0,00 VND");
        }

        protected void Muathem_Click(object sender, EventArgs e)
        {
            Response.Redirect("SanPham.aspx");
        }

        protected void Thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ddt = new DataTable();
                ddt = (DataTable)Session.Contents["TaiKhoan"];

                XulyThemDonHang insert_donhang = new XulyThemDonHang();
                insert_donhang.Donhang.Email = ddt.Rows[0]["Email"].ToString();
                insert_donhang.Donhang.NgayDatHang = DateTime.Now;
                insert_donhang.Donhang.NgayYeuCau = DateTime.Parse(txtNgayChuyen.Text);
                insert_donhang.Donhang.DiaChiNhan = txtDiaChiNhan.Text;
                try
                {
                    insert_donhang.Thucthi();
                }
                catch { LbThongbao.Text = "Kiểm tra lại ngày tháng"; }

                XulyLayMaxIDDonHang madonhang = new XulyLayMaxIDDonHang();
                int MaDonHang = int.Parse(madonhang.LayID());

                DataTable table_giohang = new DataTable();
                table_giohang = (DataTable)Session.Contents["Cart"];

                foreach (DataRow dr in table_giohang.Rows)
                {
                    XulyThemGioHang insert_Giohang = new XulyThemGioHang();
                    insert_Giohang.Giohang.MaDonHang = MaDonHang;
                    insert_Giohang.Giohang.MaSanPham = int.Parse(dr[0].ToString());
                    insert_Giohang.Giohang.DonGia = int.Parse(dr[2].ToString());
                    insert_Giohang.Giohang.SoLuong = int.Parse(dr[3].ToString());
                    insert_Giohang.Giohang.TongTien = int.Parse(dr[4].ToString());
                    insert_Giohang.Thucthi();
                }

                #region Update SoLuong

                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
                    con.Open();

                    DataTable bang_giohang = new DataTable();
                    bang_giohang = (DataTable)Session.Contents["Cart"];

                    try
                    {
                        foreach (DataRow dr in bang_giohang.Rows)
                        {
                            int MaSanPham = int.Parse(dr[0].ToString());
                            int SoLuong = int.Parse(dr[3].ToString());
                            SqlCommand cmd = new SqlCommand("Update [WebBanDT].[dbo].[ThongTinSanPham] set SoLuong = SoLuong - " + SoLuong + " where MaSanPham = " + MaSanPham + "");
                            cmd.Connection = con;
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();

                        multiview1.ActiveViewIndex = 1;
                        ((DataTable)Session.Contents["Cart"]).Clear();
                    }
                    catch (Exception)
                    {
                        LbThongbao.Text = "Sản phẩm hết hàng!, xin hãy kiểm tra lại";
                    }
                }
                catch (Exception) { }
                #endregion

               // multiview1.ActiveViewIndex = 1;
               //((DataTable)Session.Contents["Cart"]).Clear();
            }
            catch { LbThongbao.Text = "Lỗi hệ thống"; }
            
        }

        protected void Huygiohang_Click(object sender, EventArgs e)
        {
            ((DataTable)Session.Contents["Cart"]).Clear();
            grv_GioHang.DataSource = (DataTable)Session.Contents["Cart"];
            grv_GioHang.DataBind();
            LbThongbao.Text = "Hủy thành công..........";
            
        }

        protected void grv_PageChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void grv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grv_GioHang.EditIndex = -1;
            this.Load_gridview();
        }

        protected void grv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            dttable = (DataTable)Session["Cart"];
            dttable.Rows.RemoveAt(e.RowIndex);
            Session["Cart"] = dttable;
            this.Load_gridview();
            Total();
            if (dttable.Rows.Count == 0)
            {
                LbThongbao.Text = "Không còn sản phẩm nào trong giỏ hàng";
            }
        }

        protected void grv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grv_GioHang.EditIndex = e.NewEditIndex;
            this.Load_gridview();
            Total();
        }

        protected void grv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                string str = grv_GioHang.DataKeys[e.RowIndex].Values[0].ToString();

                TextBox soluong = (TextBox)grv_GioHang.Rows[e.RowIndex].FindControl("txtSoLuong");

                DataTable dt = new DataTable();
                dt = (DataTable)Session["Cart"];
                XulyLayTen_GiaSanPham name_cost = new XulyLayTen_GiaSanPham();
                name_cost.Thongtinsanpham.MaSanPham = int.Parse(str);
                name_cost.Thucthi();
                string name = name_cost.LaytenSP();
                if (dt.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (int.Parse(dr[0].ToString()) == int.Parse(str))
                        {
                            dr[3] = int.Parse(soluong.Text);
                            dr[4] = Convert.ToInt32(dr[2]) * Convert.ToInt32(dr[3]);
                        }
                    }
                }
                Session["Cart"] = dt;
                grv_GioHang.EditIndex = -1;
                this.Load_gridview();
                Total();
            }
            catch { multiview1.ActiveViewIndex = 3; }
        }

        protected void gvDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgThanhThoan.Visible = true;
            imgThanhToanBaoKim.Visible = true;
        }
        
        //--------------------Thanh Toan Qua NganLuong.vn------------------------//
        protected void imgThanhThoan_Click(object sender, ImageClickEventArgs e)
        {
            //Định nghĩa các thông tin cần thiết và tạo nút thanh toán 
            String receiver = "tannm2705@gmail.com";
            String comments = "Hãy lập trình ghi chú của bạn vào đây";
            String return_url = "https://nganluong.vn/";
            String gia = gvDonHang.SelectedRow.Cells[6].Text.Replace(",",""); //Chuyen dang 1,000 -> 1000
            String price = gia.Replace("VND", ""); //Xoa chu VND
            String product = gvDonHang.SelectedRow.Cells[0].Text;
            this.url_checkout += "?receiver=" + receiver + "&comments=" + comments + "&return_url=" + return_url + "&product=" + product + "&price=" + price;
          //  imgThanhThoan.PostBackUrl = this.url_checkout;
            Response.Redirect(this.url_checkout);
        }

        //--------------------Thanh Toan Qua BaoKim.vn--------------------------//
        protected void imgThanhToanBaoKim_Click(object sender, ImageClickEventArgs e)
        {
            //Định Nghĩa các thông tin cần thiết và tạo nút thanh toán
            String business = "tannm2705@gmail.com";
            String order_id = gvDonHang.SelectedRow.Cells[0].Text;
            String gia = gvDonHang.SelectedRow.Cells[6].Text.Replace(",", ""); //Chuyen dang 1,000 -> 1000
            String total_amount = gia.Replace("VND", ""); //Xoa chu VND
            this.url_checkout_baokim += "?order_id=" + order_id + "?business=" + business + "?total_amount=" + total_amount;
            Response.Redirect(this.url_checkout_baokim);
        }

        public void UpdateSoLuong()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            con.Open();

            DataTable bang_giohang = new DataTable();
            bang_giohang = (DataTable)Session.Contents["Cart"];

            try
            {
                foreach (DataRow dr in bang_giohang.Rows)
                {
                    int MaSanPham = int.Parse(dr[0].ToString());
                    int SoLuong = int.Parse(dr[3].ToString());
                    SqlCommand cmd = new SqlCommand("Update [WebBanDT].[dbo].[ThongTinSanPham] set SoLuong = SoLuong - " + SoLuong + " where MaSanPham = " + MaSanPham + "");
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception)
            {
                LbThongbao.Text = "Sản phẩm hết hàng!, xin hãy kiểm tra lại";
            }
        }


    }
}
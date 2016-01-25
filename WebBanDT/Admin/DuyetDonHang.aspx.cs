using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using BusinessLogic;
using Common;

namespace WebBanDT.Admin
{
    public partial class DuyetDonHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session.Contents["TrangThai"].ToString().CompareTo("ChuaDangNhap") == 0)
                {
                    Response.Redirect("~/Admin/Dangnhapadmin.aspx");
                }
                this.Load_grv();
                this.Load_grv1();
                GridView1.Visible = false;
            }

        }

        public void Load_grv()
        {
            XulyThongKeDonHang donhang = new XulyThongKeDonHang();
            donhang.Thucthi();
            GridView3.DataSource = donhang.Table_Donhang;
            GridView3.DataBind();
            multiview1.ActiveViewIndex = 0;
        }

        private void Load_gridview1( int id)
        {
            XulyThongKeSanPhamNguoiMua giohang = new XulyThongKeSanPhamNguoiMua();
            giohang.Dh.MaDonHang = id;
            giohang.Thucthi();
            gridview2.DataSource = giohang.Table_Giohang;
            gridview2.DataBind();
            multiview1.ActiveViewIndex = 1;       
        }


        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
             int id = int.Parse(GridView3.SelectedRow.Cells[1].Text);
             string Hoten = GridView3.SelectedRow.Cells[3].Text;
             string Email = GridView3.SelectedRow.Cells[2].Text;
             string DiaChiGui = GridView3.SelectedRow.Cells[6].Text;
             string NgayDatHang = GridView3.SelectedRow.Cells[5].Text;
             string NgayYeuCau = GridView3.SelectedRow.Cells[4].Text;
             lbHoTen.Text = Hoten;
             lbEmail.Text = Email;
             lbDiaChiGui.Text = DiaChiGui;
             lbNgayDatHang.Text = NgayDatHang;
             lbNgayYeuCau.Text = NgayYeuCau;
             Load_gridview1(id);

        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int madon = int.Parse(GridView3.DataKeys[e.RowIndex].Values[0].ToString());
            XulyXoaDonHang Delete_Donhang = new XulyXoaDonHang();
            Delete_Donhang.Donhang.MaDonHang = madon;
            Delete_Donhang.Thuthi();
            this.Load_grv();
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int madon = int.Parse(GridView3.DataKeys[e.RowIndex].Values[0].ToString());
            XulyCapNhatDonHang Update_DonHang = new XulyCapNhatDonHang();
            TextBox ngaychuyen = (TextBox)GridView3.Rows[e.RowIndex].FindControl("txtNgayChuyen");
            TextBox TinhTrang = (TextBox)GridView3.Rows[e.RowIndex].FindControl("txtTinhTrang");
            Update_DonHang.Donhang.MaDonHang = madon;
            Update_DonHang.Donhang.NgayChuyen = DateTime.Parse(ngaychuyen.Text);
            Update_DonHang.Donhang.TinhTrang = TinhTrang.Text;
            Update_DonHang.Thucthi();

            GridView3.EditIndex = -1;
            this.Load_grv();
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            this.Load_grv();
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            this.Load_grv();
        }

        private void Load_grv1() {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
            string strDate = txtStartDate.Text;
            string endDate = txtEndDate.Text;
            con.Open();
            SqlCommand cmd = new SqlCommand("select a.MaDonHang,b.Email,b.HoTen,a.NgayYeuCau, a.NgayDatHang, a.DiaChiNhan, a.NgayChuyen, a.TinhTrang from DonHang a, NguoiDung b where a.Email = b.Email and a.NgayDatHang between ('" + strDate + "') and ('" + endDate + "');");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
            con.Close();
                }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(txtStartDate.Text.Trim()) > Convert.ToDateTime(txtEndDate.Text.Trim()))
            {
                LbThongbao.Text = "Ngày bắt đầu phải nhỏ hơn ngày kết thúc!!!";
            }
            else
            {
                this.Load_grv1();
                GridView3.Visible = false;
                GridView1.Visible = true;
            }
        }  
        
        // GridView1 Event
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(GridView1.SelectedRow.Cells[1].Text);
            string Hoten = GridView1.SelectedRow.Cells[3].Text;
            string Email = GridView1.SelectedRow.Cells[2].Text;
            string DiaChiGui = GridView1.SelectedRow.Cells[6].Text;
            string NgayDatHang = GridView1.SelectedRow.Cells[5].Text;
            string NgayYeuCau = GridView1.SelectedRow.Cells[4].Text;
            lbHoTen.Text = Hoten;
            lbEmail.Text = Email;
            lbDiaChiGui.Text = DiaChiGui;
            lbNgayDatHang.Text = NgayDatHang;
            lbNgayYeuCau.Text = NgayYeuCau;
            Load_gridview1(id);

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int madon = int.Parse(GridView1.DataKeys[e.RowIndex].Values[0].ToString());
            XulyXoaDonHang Delete_Donhang = new XulyXoaDonHang();
            Delete_Donhang.Donhang.MaDonHang = madon;
            Delete_Donhang.Thuthi();

            this.Load_grv1();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int madon = int.Parse(GridView1.DataKeys[e.RowIndex].Values[0].ToString());
            XulyCapNhatDonHang Update_DonHang = new XulyCapNhatDonHang();
            TextBox ngaychuyen = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtNgayChuyen");
            TextBox TinhTrang = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtTinhTrang");
            Update_DonHang.Donhang.MaDonHang = madon;
            Update_DonHang.Donhang.NgayChuyen = DateTime.Parse(ngaychuyen.Text);
            Update_DonHang.Donhang.TinhTrang = TinhTrang.Text;
            Update_DonHang.Thucthi();

            GridView1.EditIndex = -1;
            this.Load_grv1();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.Load_grv1();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.Load_grv1();
        }

        //End GridView1 event
    }
}
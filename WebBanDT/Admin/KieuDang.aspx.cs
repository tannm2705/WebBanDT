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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session.Contents["TrangThai"].ToString().CompareTo("ChuaDangNhap") == 0)
                {
                    Response.Redirect("~/Admin/Dangnhapadmin.aspx");
                }
                this.Load_gridview();
            }
        }

        private void Load_gridview()
        {
            XulyLayAllThongTinKieuDang kieudang = new XulyLayAllThongTinKieuDang();
            kieudang.Thucthi();
            grv_KieuDang.DataSource = kieudang.ketqua;
            grv_KieuDang.DataBind();
        }
        protected void grv_PageChangging(object sender, GridViewPageEventArgs e)
        {
            grv_KieuDang.PageIndex = e.NewPageIndex;
            this.Load_gridview();
        }

        protected void grv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grv_KieuDang.EditIndex = -1;
            this.Load_gridview();
        }

        protected void grv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grv_KieuDang.EditIndex = e.NewEditIndex;
            this.Load_gridview();
        }

        protected void grv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string maKieuDang = grv_KieuDang.DataKeys[e.RowIndex].Values[0].ToString();
            TextBox tenKieuDang = (TextBox)grv_KieuDang.Rows[e.RowIndex].FindControl("txtTenKieuDang");
            XulySuaThongTinKieuDang update_kieudang = new XulySuaThongTinKieuDang();
            update_kieudang.Kieudang.MaKieuDang = maKieuDang;
            update_kieudang.Kieudang.TenKieuDang = tenKieuDang.Text;
            update_kieudang.ThucThi();

            grv_KieuDang.EditIndex = -1;
            this.Load_gridview();
        }

        protected void grv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string maKieuDang = grv_KieuDang.DataKeys[e.RowIndex].Values[0].ToString();
            XulyXoaThongTinKieuDang delete_kieudang = new XulyXoaThongTinKieuDang();
            delete_kieudang.Kdang.MaKieuDang = maKieuDang;
            delete_kieudang.Thucthi();

            this.Load_gridview();
        }
        protected void ThemKieuDang_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                XulyThemKieuDang themkieudang = new XulyThemKieuDang();
                KieuDang kieudang = new KieuDang();
                kieudang.MaKieuDang = txtMaKieuDang.Text;
                kieudang.TenKieuDang = txtTenKieuDang.Text;
                themkieudang.kieudang = kieudang;

                try { themkieudang.Thucthi(); this.Load_gridview(); txtMaKieuDang.Text = ""; txtTenKieuDang.Text = ""; }
                catch { lableThongbao.Text = "Kiểm tra thông tin nhập vào! Có thể trùng mã kiểu dáng"; }
            }
        }
    }
}
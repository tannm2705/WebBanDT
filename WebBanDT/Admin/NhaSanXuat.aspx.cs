using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using Common;

namespace WebBanDT.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    if (Session.Contents["TrangThai"].ToString().CompareTo("ChuaDangNhap") == 0)
                    {
                        Response.Redirect("~/Admin/Dangnhapadmin.aspx");
                    }
                    this.load_gridview();
            }
        }
        private void load_gridview()
        {
            XulyLayAllthongtinNhaSX nsx = new XulyLayAllthongtinNhaSX();
            nsx.Thucthi();
            grv_NhaSX.DataSource = nsx.Ketqua;
            grv_NhaSX.DataBind();
        }

        protected void grv_PageChangging(object sender, GridViewPageEventArgs e)
        {
            grv_NhaSX.PageIndex = e.NewPageIndex;
            this.load_gridview();
        }

        protected void grv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grv_NhaSX.EditIndex = -1;
            this.load_gridview();
        }

        protected void grv_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            XulyXoaThongTinNhaSX delete_nhasx = new XulyXoaThongTinNhaSX();
            string mansx = grv_NhaSX.DataKeys[e.RowIndex].Values[0].ToString();
            delete_nhasx.Nhasx.MaNSX = mansx;
            delete_nhasx.Thucthi();

            this.load_gridview();
        }

        protected void grv_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grv_NhaSX.EditIndex = e.NewEditIndex;
            this.load_gridview();
        }

        protected void grv_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string mansx = grv_NhaSX.DataKeys[e.RowIndex].Values[0].ToString();
            TextBox tennsx = (TextBox)grv_NhaSX.Rows[e.RowIndex].FindControl("txtTenNSX");
            XulySuaThongTinNhaSX update_nhasx = new XulySuaThongTinNhaSX();
            update_nhasx.Nhasx.MaNSX = mansx;
            update_nhasx.Nhasx.TenNSX = tennsx.Text;
            update_nhasx.Thucthi();

            grv_NhaSX.EditIndex = -1;
            this.load_gridview();
        }

        protected void ThemNhaSX_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                XulyThemNhaSX themNSX = new XulyThemNhaSX();
                NhaSX nhasx = new NhaSX();
                nhasx.MaNSX = txtMaNSX.Text;
                nhasx.TenNSX = txtTenNSX.Text;
                themNSX.nhasx = nhasx;
                try
                {
                    themNSX.Thucthi();
                    this.load_gridview();
                }
                catch
                {
                    lableThongbao.Text = "Kiểm tra thông tin nhập vào! Có thể trùng MaNSX";
                }
            }
        }
    }
}
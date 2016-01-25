using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace WebBanDT.Admin
{
    public partial class TinRaoVat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                if (Session.Contents["TrangThai"].ToString().CompareTo("ChuaDangNhap") == 0)
                {
                    Response.Redirect("~/Admin/Dangnhapadmin.aspx");
                }
                Loadgridview();
            }
            
        }

        public void Loadgridview()
        {
            XulyTruyXuatTinRaoVat select_tinraovat = new XulyTruyXuatTinRaoVat();
            select_tinraovat.Thucthi();
            gridview1.DataSource = select_tinraovat.Table;
            gridview1.DataBind();
        }
        protected void gridview1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridview1.EditIndex = e.NewEditIndex;
            Loadgridview();
        }

        protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Matin = int.Parse(gridview1.DataKeys[e.RowIndex].Values[0].ToString());
            XulyXoaTinRaoVat delete_tinraovat = new XulyXoaTinRaoVat();
            delete_tinraovat.Tinraovat.MaTin = Matin;
            delete_tinraovat.Thucthi();

            Loadgridview();
        }

        protected void gridview1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Matin = int.Parse(gridview1.DataKeys[e.RowIndex].Values[0].ToString());
            TextBox tieude = (TextBox)gridview1.Rows[e.RowIndex].FindControl("txtTieuDe");
            TextBox Link = (TextBox)gridview1.Rows[e.RowIndex].FindControl("txtLink");
            TextBox NgayDang = (TextBox)gridview1.Rows[e.RowIndex].FindControl("txtNgayDang");

            XulyCapNhatTinRaoVAt update_tinraovat = new XulyCapNhatTinRaoVAt();
            update_tinraovat.Tinraovat.MaTin = Matin;
            update_tinraovat.Tinraovat.TieuDe = tieude.Text;
            update_tinraovat.Tinraovat.Link = Link.Text;
            update_tinraovat.Tinraovat.NgayDang = Convert.ToDateTime(NgayDang.Text);
            update_tinraovat.Thuthi();

            gridview1.EditIndex = -1;
            Loadgridview();
        }

        protected void gridview1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridview1.PageIndex = e.NewPageIndex;
            Loadgridview();
        }

        protected void gridview1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridview1.EditIndex = -1;
            Loadgridview();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            XulyThemTinRaoVat insert_tinraovat = new XulyThemTinRaoVat();
            insert_tinraovat.Tinraovat.TieuDe = txtTieu_De.Text;
            insert_tinraovat.Tinraovat.Link = txt_Link.Text;
            insert_tinraovat.Tinraovat.NgayDang = Convert.ToDateTime(txt_NgayDang.Text);
            insert_tinraovat.Thucthi();

            Loadgridview();
            txt_Link.Text = "";
            txt_NgayDang.Text = "";
            txtTieu_De.Text = "";
        }
    }
}
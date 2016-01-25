using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using BusinessLogic;
using Common;

namespace WebBanDT.Controler
{
    public partial class GridViewXoaSua : System.Web.UI.UserControl
    {
        private NguoiDung nguoidung1 = new NguoiDung();

        public NguoiDung Nguoidung1
        {
            get { return nguoidung1; }
            set { nguoidung1 = value; }
        }

        private NguoiDung nguoidung2 = new NguoiDung();

        public NguoiDung Nguoidung2
        {
            get { return nguoidung2; }
            set { nguoidung2 = value; }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                this.hienthi();
        }

        public void hienthi()
        {
            XulyTruyXuatAllThongTinNguoiDung use = new XulyTruyXuatAllThongTinNguoiDung();
            use.Thucthi();
            grvNguoiDung.DataSource = use.ketqua;
            grvNguoiDung.DataBind();
        }
        protected void imgDelAll_Click(object sender, ImageClickEventArgs e)
        { }
        protected void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }
        //lam xong
        protected void grvProduct_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvNguoiDung.EditIndex = -1;
            this.hienthi();
        }

        //lam xong
        protected void grvProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Nguoidung2.Email = grvNguoiDung.DataKeys[e.RowIndex].Value.ToString();
            XulyXoaNguoiDung delete = new XulyXoaNguoiDung();
            delete.Nguoidung.Email = Nguoidung2.Email;
            delete.Thucthi();
            this.hienthi();
        }

        //lam xong
        protected void grvProduct_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvNguoiDung.EditIndex = e.NewEditIndex;
            this.hienthi();
        }
        //lam xong
        protected void grvProduct_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Nguoidung1.Email = grvNguoiDung.DataKeys[e.RowIndex].Value.ToString();
            Nguoidung1.MatKhau = ((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            nguoidung1.HoTen = ((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            Nguoidung1.DiaChi = ((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            Nguoidung1.SoDT = ((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            Nguoidung1.SoFax = ((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            Nguoidung1.MaKieuNguoiDung = int.Parse(((TextBox)grvNguoiDung.Rows[e.RowIndex].Cells[7].Controls[0]).Text);
            XulySuaThongTinNguoiDung update = new XulySuaThongTinNguoiDung();
            update.Nguoidung = this.Nguoidung1;
            update.Thucthi();
            grvNguoiDung.EditIndex = -1;
            this.hienthi();
        }

        protected void grvNguoiDung_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvNguoiDung.PageIndex = e.NewPageIndex;
            this.hienthi();
        }
       
    
    }
}
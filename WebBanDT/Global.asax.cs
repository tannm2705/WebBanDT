using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
namespace WebBanDT
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            int songuoi_online = 0;
            Application["online"] = songuoi_online;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Add("TrangThai","ChuaDangNhap");
            Session.Add("TrangThaiUse","ChuaDangNhap");
            Session.Add("Search","");
            DataTable table = new DataTable();
            table.Columns.Add( new DataColumn("ID",typeof(Int32)));
            table.Columns.Add(new DataColumn("TenSanPham",typeof(string)));
            table.Columns.Add(new DataColumn("GiaTien",typeof(double)));
            table.Columns.Add(new DataColumn("SoLuong",typeof(Int32)));
            table.Columns.Add(new DataColumn("TongTien",typeof(double)));
            Session["Cart"] = table;

            Session.Add("use","taolao");
            DataTable dttable = new DataTable();
            dttable.Columns.Add(new DataColumn("Email", typeof(string)));
            dttable.Columns.Add(new DataColumn("HoTen",typeof(string)));
            Session["TaiKhoan"] = dttable;

            //Session.Timeout = 10;
            //thong ke so nguoi truy cap
            int count_visit = 0;
            if (System.IO.File.Exists(Server.MapPath("SL.txt")) == false)
            {
                count_visit = 1;
            }
            else
            {
                System.IO.StreamReader read = new System.IO.StreamReader(Server.MapPath("SL.txt"));
                count_visit = int.Parse(read.ReadLine());
                read.Close();
                count_visit++;
            }
            Application.Lock();
            Application["SL"] = count_visit;
            Application.UnLock();
            System.IO.StreamWriter writer = new System.IO.StreamWriter(Server.MapPath("SL.txt"));
            writer.WriteLine(count_visit);
            writer.Close();
            //===============================================//
            //dem so nguoi dang online
            Application["online"] = Convert.ToInt32(Application["online"].ToString()) + 1;

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["online"] = Convert.ToInt32(Application["online"].ToString()) -1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
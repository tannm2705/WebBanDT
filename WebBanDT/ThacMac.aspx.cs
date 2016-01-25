using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace WebBanDT
{
    public partial class ThacMac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNguoiNhan.Text = "tannm2705@gmail.com";
            multiview1.ActiveViewIndex = 0;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SendMail();
        }

        public void SendMail()
        {

            MailMessage mail = new MailMessage();
            //mail.To.Add(txtTo.Text);
            mail.To.Add(txtNguoiNhan.Text);
            //mail.From = new MailAddress(txtFrom.Text);
            mail.From = new MailAddress(txtEmailYou.Text);
            //mail.Subject = txtSubject.Text;
            mail.Subject = txtTieuDe.Text;
            //mail.Body = txtMessage.Text;
            mail.Body = txtNoiDung.Text;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
            smtp.Credentials = new System.Net.NetworkCredential(txtEmailYou.Text,txtPass.Text);
            //Or your Smtp Email ID and Password
            smtp.EnableSsl = true;
            try { smtp.Send(mail); multiview1.ActiveViewIndex = 1; }
            catch { multiview1.ActiveViewIndex = 2; return; }
        }
    }
}
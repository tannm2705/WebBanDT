using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace WebBanDT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string Pass = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            multiview1.ActiveViewIndex = 0;
        }

        protected void btb_GetPass_Click(object sender, EventArgs e)
        {
                SendMail();
        }

        private void SendMail()
        {
                XuLyKiemTraThongTinDangNhap dn=new XuLyKiemTraThongTinDangNhap();
                dn.nguoidung.Email = txt_Email1.Text;
                if (dn.KiemTraEmail() == 1)
                {
                    XulyGetPass getpass = new XulyGetPass();
                    getpass.NgDung.Email = txt_Email1.Text;
                    getpass.Thucthi();
                    Pass = getpass.Pass;


                    MailMessage mail = new MailMessage();
                    //mail.To.Add(txtTo.Text);
                    mail.To.Add(dn.nguoidung.Email);
                    //mail.From = new MailAddress(txtFrom.Text);
                    mail.From = new MailAddress("duchienntu@gmail.com");
                    //mail.Subject = txtSubject.Text;
                    mail.Subject = "www.Didongonline.com";
                    //mail.Body = txtMessage.Text;
                    mail.Body = "Thông báo từ ban quản trị website Didongonline.com:  Mật khẩu đăng nhập vào website của bạn là: " + Pass;
                    mail.IsBodyHtml = true;

                    //Attach file using FileUpload Control and put the file in memory stream
                    //if (FileUpload1.HasFile)
                    // {
                    //      mail.Attachments.Add(new Attachment(FileUpload1.PostedFile.InputStream, FileUpload1.FileName));
                    //  }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                    smtp.Credentials = new System.Net.NetworkCredential
                         ("duchienntu@gmail.com", "19910519");
                    //Or your Smtp Email ID and Password
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    multiview1.ActiveViewIndex = 1;
                }
                else if(dn.KiemTraEmail()==0)
                {
                    multiview1.ActiveViewIndex = 2; return;
                }
            }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            multiview1.ActiveViewIndex = 0;
        }
            
            
    }
}


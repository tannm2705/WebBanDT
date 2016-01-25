using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccess.Select;
using BusinessLogic;

namespace WebBanDT.Web
{
    public partial class TrangChu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThiSPTheoPC1.Maphongcach = "1";
            HienThiSPTheoPC2.Maphongcach = "2";
            HienThiSPTheoPC3.Maphongcach = "3";

            lbthongke.Text= Application.Contents["SL"].ToString();
            lbthongkeonline.Text = Application.Contents["online"].ToString();
        }
    }
}
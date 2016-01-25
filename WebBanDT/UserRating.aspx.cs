using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace WebBanDT
{
    public partial class UserRating : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["WebBanDTConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRatingControl();
            }
        }

        protected void RatingControlChanged(object sender, AjaxControlToolkit.RatingEventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RatingDetails(Rate)values(@Rating)", con);
            cmd.Parameters.AddWithValue("@Rating", ratingControl.CurrentRating);
            cmd.ExecuteNonQuery();
            con.Close();
            BindRatingControl();

        }

        protected void BindRatingControl()
        {
            int total = 0;

            DataTable dt = new DataTable();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Rate from RatingDetails", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += Convert.ToInt32(dt.Rows[i][0].ToString());
                }
                int average = total / (dt.Rows.Count);
                ratingControl.CurrentRating = average;
                lbltxt.Text = dt.Rows.Count + " user(s) have rated this article";
            }
        }
    }
}
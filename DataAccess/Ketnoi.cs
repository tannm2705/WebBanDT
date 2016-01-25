using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
   public class Ketnoi
    {
       public string ConnectionString()
       {
           return WebConfigurationManager.ConnectionStrings["SQLCONN"].ConnectionString;
       }
    }
}

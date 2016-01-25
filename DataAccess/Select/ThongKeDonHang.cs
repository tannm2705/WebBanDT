using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace DataAccess.Select
{
   public class ThongKeDonHang
    {

       public SqlDataSource Table_Donhang()
       {
           Ketnoi kn = new Ketnoi();
           SqlDataSource sql = new SqlDataSource();
           sql.ConnectionString = kn.ConnectionString();
           sql.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sql.SelectCommand = "ThongKeDonHang";
           return sql;
       }
    }
}

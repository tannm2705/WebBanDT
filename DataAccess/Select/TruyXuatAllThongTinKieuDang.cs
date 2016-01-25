using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace DataAccess.Select
{
   public class TruyXuatAllThongTinKieuDang
    {
       public SqlDataSource Laydulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           Ketnoi stringconnect = new Ketnoi();
           sqldata.ConnectionString = stringconnect.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "KieuDang_SelectAll";
           return sqldata;
       }

    }
}

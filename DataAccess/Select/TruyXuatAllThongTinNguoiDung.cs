using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;

namespace DataAccess.Select
{
   public class TruyXuatAllThongTinNguoiDung
    {
       public SqlDataSource Laydulieu()
       {
           Ketnoi kn = new Ketnoi();
           SqlDataSource sqldata = new SqlDataSource();
           sqldata.ConnectionString = kn.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "NguoiDung_SelectAll";
           return sqldata;
       }
    }
}

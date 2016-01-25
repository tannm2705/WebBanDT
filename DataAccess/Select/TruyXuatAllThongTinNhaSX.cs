using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Common;
namespace DataAccess.Select
{

   public class TruyXuatAllThongTinNhaSX
    {
       private NhaSX _NhaSX;
       public NhaSX Nhasx
       {
           get { return _NhaSX; }
           set { _NhaSX = value; }
       }

       public SqlDataSource Laydulieu()
       {
           SqlDataSource sqldata = new SqlDataSource();
           Ketnoi stringconnect = new Ketnoi();
           sqldata.ConnectionString = stringconnect.ConnectionString();
           sqldata.SelectCommandType = SqlDataSourceCommandType.StoredProcedure;
           sqldata.SelectCommand = "NhaSX_SelectAll";
           return sqldata;
       }
    }
}

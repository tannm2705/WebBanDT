using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using DataAccess.Select;
using System.Data;
using Common;

namespace BusinessLogic
{
   public class XulyLayAllthongtinNhaSX
    {
       private SqlDataSource _ketqua;

       public SqlDataSource Ketqua
       {
           get { return _ketqua; }
           set { _ketqua = value; }
       }
       public void Thucthi()
       {
           TruyXuatAllThongTinNhaSX dulieuNhaSX = new TruyXuatAllThongTinNhaSX();
           Ketqua=dulieuNhaSX.Laydulieu();
       }

    }
}

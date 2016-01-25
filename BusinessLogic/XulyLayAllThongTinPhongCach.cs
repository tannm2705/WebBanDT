using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using DataAccess.Select;

namespace BusinessLogic
{
   public class XulyLayAllThongTinPhongCach
    {
       private SqlDataSource _ketqua;
       public SqlDataSource ketqua
       {
           get { return _ketqua; }
           set { _ketqua = value; }
       }

       public void Thucthi()
       {
           TruyXuatAllThongTinPhongCach phongcach = new TruyXuatAllThongTinPhongCach();
           ketqua = phongcach.Laydulieu();
       }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using DataAccess.Select;

namespace BusinessLogic
{
   public class XulyThongKeDonHang
    {

        private SqlDataSource table_Donhang = new SqlDataSource();

        public SqlDataSource Table_Donhang
        {
            get { return table_Donhang; }
            set { table_Donhang = value; }
        }

        public void Thucthi()
        {
            ThongKeDonHang donhang = new ThongKeDonHang();
            table_Donhang = donhang.Table_Donhang();
        }
    }
}

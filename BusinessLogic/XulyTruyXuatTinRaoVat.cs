using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common;
using DataAccess.Select;


namespace BusinessLogic
{
    public class XulyTruyXuatTinRaoVat
    {
        private DataTable table = new DataTable();

        public DataTable Table
        {
            get { return table; }
            set { table = value; }
        }

        
        public void Thucthi()
        {
            TruyXuatTinRaoVat tinraovat = new TruyXuatTinRaoVat();
            Table = tinraovat.GetTinRaoVat();
        }
    }
}

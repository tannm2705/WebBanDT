using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Select;
using Common;
using System.Data;

namespace BusinessLogic
{
   public class XulyLayTen_GiaSanPham
    {
        private ThongTinSanPham _thongtinsanpham = new ThongTinSanPham();

        public ThongTinSanPham Thongtinsanpham
        {
            get { return _thongtinsanpham; }
            set { _thongtinsanpham = value; }
        }
        private DataTable _table = new DataTable();

        public DataTable Table
        {
            get { return _table; }
            set { _table = value; }
        }
        public void Thucthi()
        {
            TruyXuatThongTinSanPhamByID sanphambyID = new TruyXuatThongTinSanPhamByID();
            sanphambyID.thongtinsanpham.MaSanPham = this.Thongtinsanpham.MaSanPham;
            Table = sanphambyID.table();
        }

        public string LaytenSP()
        {
            
            string name = Table.Rows[0]["TenSanPham"].ToString();
            return name;
        }

        public double LayGiaSP()
        {
            int gia = (int)Table.Rows[0]["GiaSanPham"];
            return gia;
        }
    }
}

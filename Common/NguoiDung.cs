using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
  public  class NguoiDung
    {
        private string _Email;
        private string _MatKhau;
        private string _HoTen;
        private string _DiaChi;
        private string _SoDT;
        private string _SoFax;
        private int _MaKieuNguoiDung;

        public NguoiDung()
        {
            _Email = "";
            _MatKhau = "";
            _HoTen = "";
            _DiaChi = "";
            _SoDT = "";
            _SoFax = "";
            _MaKieuNguoiDung = 0;
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string SoDT
        {
            get { return _SoDT; }
            set { _SoDT = value; }
        }
        public string SoFax
        {
            get { return _SoFax; }
            set { _SoFax = value; }
        }
        public int MaKieuNguoiDung
        {
            get { return _MaKieuNguoiDung; }
            set { _MaKieuNguoiDung = value; }
        }
    }
}

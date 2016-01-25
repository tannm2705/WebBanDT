using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class ThongTinSanPham
    {
       public ThongTinSanPham() { this.top = 0; this._MaSanPham = 0; ImageSP = ""; }
        private int _MaSanPham;
        private string _MaNSX;
        private string _MaKieuDang;
        private string _MaPhongCach;
        private string _TenSanPham;
        private string _MoTa;
        private int _GiaSanPham;
        private string _ImageSP;
        private int _SoLuong;
        private string _TenHDH;
        private string _RAM;
        private string _Camera;
        private int _Pin;
        private int _top;

        public int top
        {
            get { return _top; }
            set { _top = value; }
        }
        public int MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }
        public string MaNSX
        {
            get { return _MaNSX; }
            set { _MaNSX = value; }
        }
        public string MaKieuDang
        {
            get { return _MaKieuDang; }
            set { _MaKieuDang = value; }
        }
        public string MaPhongCach
        {
            get { return _MaPhongCach; }
            set { _MaPhongCach = value; }
        }
        public string TenSanPham
        {
            get { return _TenSanPham; }
            set { _TenSanPham = value; }
        }
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
        public int GiaSanPham
        {
            get { return _GiaSanPham; }
            set { _GiaSanPham = value; }
        }
        public string ImageSP
        {
            get { return _ImageSP; }
            set { _ImageSP = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value;  }
        }

        public string TenHDH
        {
            get { return _TenHDH; }
            set { _TenHDH = value; }
        }

        public string RAM
        {
            get { return _RAM; }
            set { _RAM = value; }
        }

        public string Camera
        {
            get { return _Camera; }
            set { _Camera = value; }
        }

        public int Pin
        {
            get { return _Pin; }
            set { _Pin = value; }
        }

        private NhaSX _nhasx =new NhaSX();

        public NhaSX Nhasx
        {
            get { return _nhasx; }
            set { _nhasx = value; }
        }

        private PhongCach _phongcach=new PhongCach();

        public PhongCach Phongcach
        {
            get { return _phongcach; }
            set { _phongcach = value; }
        }

        private KieuDang _kieudang=new KieuDang();

        public KieuDang Kieudang
        {
            get { return _kieudang; }
            set { _kieudang = value; }
        }
    }
}

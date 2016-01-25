using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class GioHang
    {
     public GioHang()
	 {
	 }
	 private int _MaSanPham ;
	 private int _MaDonHang ;
	 private int _DonGia ;
	 private int _SoLuong ;
	 private int _TongTien ;
 

	 public int MaSanPham
	 {
	    get { return _MaSanPham ; }
	    set { _MaSanPham = value ; }
	 }
	 public int MaDonHang
	 {
	    get { return _MaDonHang ; }
	    set { _MaDonHang = value ; }
	 }
	 public int DonGia
	 {
	    get { return _DonGia ; }
	    set { _DonGia = value ; }
	 }
	 public int SoLuong
	 {
	    get { return _SoLuong ; }
	    set { _SoLuong = value ; }
	 }
	 public int TongTien
	 {
	    get { return _TongTien ; }
	    set { _TongTien = value ; }
	 }
    }
}

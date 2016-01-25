using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
   public class DonHang
    {
     public DonHang()
	 {
	 }
	 private int _MaDonHang ;
	 private string _Email ;
	 private DateTime _NgayDatHang ;
	 private DateTime _NgayYeuCau ;
	 private DateTime _NgayChuyen ;
	 private string _DiaChiNhan ;
	 private string _TinhTrang ;
 

	 public int MaDonHang
	 {
	    get { return _MaDonHang ; }
	    set { _MaDonHang = value ; }
	 }
	 public string Email
	 {
	    get { return _Email ; }
	    set { _Email = value ; }
	 }
	 public DateTime NgayDatHang
	 {
	    get { return _NgayDatHang ; }
	    set { _NgayDatHang = value ; }
	 }
	 public DateTime NgayYeuCau
	 {
	    get { return _NgayYeuCau ; }
	    set { _NgayYeuCau = value ; }
	 }
	 public DateTime NgayChuyen
	 {
	    get { return _NgayChuyen ; }
	    set { _NgayChuyen = value ; }
	 }
	 public string DiaChiNhan
	 {
	    get { return _DiaChiNhan ; }
	    set { _DiaChiNhan = value ; }
	 }
	 public string TinhTrang
	 {
	    get { return _TinhTrang ; }
	    set { _TinhTrang = value ; }
	 }
    }
}

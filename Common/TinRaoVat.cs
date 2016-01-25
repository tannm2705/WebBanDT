using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	public class TinRaoVat
	{
		
	 public TinRaoVat()
	 {
	 }
	 private int _MaTin ;
	 private string _TieuDe ;
	 private string _Link ;
	 private DateTime _NgayDang ;
 

	 public int MaTin
	 {
		get { return _MaTin ; }
		set { _MaTin = value ; }
	 }
	 public string TieuDe
	 {
		get { return _TieuDe ; }
		set { _TieuDe = value ; }
	 }
	 public string Link
	 {
		get { return _Link ; }
		set { _Link = value ; }
	 }
	 public DateTime NgayDang
	 {
		get { return _NgayDang ; }
		set { _NgayDang = value ; }
	 }
	}
}

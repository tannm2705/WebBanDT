using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Delete;
namespace BusinessLogic
{
   public class XulyXoaTinRaoVat
    {

        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }

        public void Thucthi()
        {
            XoaTinRaoVat delete_tinraovat = new XoaTinRaoVat();
            delete_tinraovat.Tinraovat.MaTin = Tinraovat.MaTin;
            delete_tinraovat.Delete_TinRaoVat();
        }
    }
}

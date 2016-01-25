using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Insert;

namespace BusinessLogic
{
   public class XulyThemTinRaoVat
    {
        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }

        public void Thucthi()
        {
            ThemTinRaoVat insert_tinraovat = new ThemTinRaoVat();
            insert_tinraovat.Tinraovat = Tinraovat;
            insert_tinraovat.Them_TinRaoVat();
        }
    }
}

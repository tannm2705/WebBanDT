using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Update;

namespace BusinessLogic
{
   public class XulyCapNhatTinRaoVAt
    {
        private TinRaoVat tinraovat = new TinRaoVat();

        public TinRaoVat Tinraovat
        {
            get { return tinraovat; }
            set { tinraovat = value; }
        }
        public void Thuthi()
        {
            CapNhatTinRaoVat update_tinraovat = new CapNhatTinRaoVat();
            update_tinraovat.Tinraovat = Tinraovat;
            update_tinraovat.Update_TinRaoVat();
        }
    }
}

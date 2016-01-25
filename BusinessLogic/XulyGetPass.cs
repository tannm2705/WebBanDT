using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using DataAccess.Select;

namespace BusinessLogic
{
    public class XulyGetPass
    {
        private NguoiDung ngDung = new NguoiDung();

        public NguoiDung NgDung
        {
            get { return ngDung; }
            set { ngDung = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public void Thucthi()
        {
            GetPass getpass = new GetPass();
            getpass.NgDung.Email = NgDung.Email;
            Pass = getpass.Get_Pass();
        }
        
    }
}

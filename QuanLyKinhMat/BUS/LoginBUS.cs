using QuanLyKinhMat.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKinhMat.BUS
{
    internal class LoginBUS
    {
        private static LoginBUS instance;

        public static LoginBUS Instance
        {
            get { if (instance == null) instance = new LoginBUS(); return instance; }
            private set { instance = value; }
        }

        private LoginBUS() { }
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

    }

}

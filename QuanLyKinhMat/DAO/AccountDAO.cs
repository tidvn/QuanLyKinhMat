using QuanLyKinhMat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKinhMat.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.Nhanvien WHERE UserName = N'" + userName + "' AND PassWord = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            try { UserDTO.Instance.Init(Convert.ToInt32(result.Rows[0].ItemArray[0])); }
            catch { }

            return result.Rows.Count > 0;
        }
    }
}

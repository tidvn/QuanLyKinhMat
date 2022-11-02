using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using QuanLyKinhMat.DAO;

namespace QuanLyKinhMat.DTO
{
    internal class UserDTO
    {
        int id;
        string username;
        string password;
        string name;
        string sex;
        DateTime birth;
        string phone;
        string address;
        int id_cv;
        int admin;

        private static UserDTO instance;
        internal static UserDTO Instance
        {
            get { if (instance == null) instance = new UserDTO(); return instance; }
            private set { instance = value; }
        }

        public int Id { get => id; }
        public string Username { get => username; }
        public string Password { get => password; }
        public string Name { get => name; }
        public string Sex { get => sex; }
        public DateTime Birth { get => birth; }
        public string Phone { get => phone; }
        public string Address { get => address; }
        public int Id_cv { get => id_cv; }
        public int Admin { get => admin; }
        private UserDTO()
        {

        }
        public void Init(int Uid)
        {
            string query = "SELECT * FROM dbo.Nhanvien WHERE id = " + Uid + " ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            this.id = Convert.ToInt32(result.Rows[0].ItemArray[0]);
            this.username = result.Rows[0].ItemArray[1].ToString();
            this.password = result.Rows[0].ItemArray[2].ToString();
            this.name = result.Rows[0].ItemArray[3].ToString();
            this.sex = result.Rows[0].ItemArray[4].ToString();
            this.birth = DateTime.Parse(result.Rows[0].ItemArray[5].ToString());
            this.phone = result.Rows[0].ItemArray[6].ToString();
            this.address = result.Rows[0].ItemArray[7].ToString();
            this.id_cv = Convert.ToInt32(result.Rows[0].ItemArray[8]);
            this.admin = Convert.ToInt32(result.Rows[0].ItemArray[9]);
        }


    }
}

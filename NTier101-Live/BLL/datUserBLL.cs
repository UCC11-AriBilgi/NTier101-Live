using NTier101_Live.DAL;
using NTier101_Live.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier101_Live.BLL
{        
    // Bu class yönlendirici bir class olacak (MVC tarafındaki Controller karşılığı gibi)
    
    public class datUserBLL
    {
        private datUserDAO datUserDAO;

        // constructor
        public datUserBLL()
        {
            datUserDAO = new datUserDAO(); // Ayağa kaldırıyorum...
        }

        public datUser getUser(int UserID)
        {
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            dataTable= datUserDAO.getUser(UserID); // DAO classında yapılan işlemin sonucunu yüklüyorum.

            foreach (DataRow row in dataTable.Rows) 
            {
                datUser.UserName = row["UserName"].ToString();
                datUser.UserPassw = row["UserPassw"].ToString();
                datUser.Ad = row["Ad"].ToString();
                datUser.Soyad = row["Soyad"].ToString();
                datUser.TCKimlik = row["TCKimlik"].ToString();
                datUser.MudurlukID = Convert.ToInt32(row["MudurlukID"].ToString());
            }

            return datUser;
        }

        public datUser searchUser(string username,string userpassw)
        {
            // Login ekranından girilen username userpassw bilgilerine göre kayıt var mı/yok mu
            datUser datUser = new datUser();

            DataTable dataTable = new DataTable();

            dataTable = datUserDAO.searchUserIDPassw(username,userpassw);

            foreach (DataRow row in dataTable.Rows)
            {
                datUser.UserName = row["UserName"].ToString();
                datUser.UserPassw = row["UserPassw"].ToString();

            }

            return datUser;

        }

        public datUser insertUser(string UserName,string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID)
        {
            datUser datUser=new datUser();
            DataTable dataTable = new DataTable();

            datUserDAO.insertUser(UserName,UserPassw,Ad,Soyad,TCKimlik,MudurlukID);

            return datUser;
        }

        public datUser updateUser(int UserID,string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            datUser datUser = new datUser();
            DataTable dataTable = new DataTable();

            datUserDAO.updateUser(UserID,UserName, UserPassw, Ad, Soyad, TCKimlik, MudurlukID);

            return datUser;
        }

        public datUser deleteUser(int UserID)
        {
            datUser datUser = new datUser();
            DataTable dataTable = new DataTable();

            datUserDAO.deleteUser(UserID);

            return datUser;
        }


    }
}

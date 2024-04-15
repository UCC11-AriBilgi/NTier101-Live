using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NTier101_Live.DAL
{
    // DB tabloları üzerinde gerekli işlemleri gerçekleştirecek olan sınıf
    // UserID-Passsword e göre arama
    // Gelen parametreye göre IUD işlemlerinin hangisi olduğunu anlayarak ilgili yere dallanacak.

    internal class datUserDAO
    {
        private DBOperation DBOperation;

        // contructor
        public datUserDAO()
        {
            DBOperation = new DBOperation(); // classı hazır tutacak sekilde nesne yaratıldı.
        }

        // Kullanıcının tablo üzerinde yapacağı cesitli arama işlemleri için...
        // Sisteme giriş için

        public DataTable searchUserIDPassw(string userName, string userPassw)
        {
            string Query = string.Format("SELECT * FROM datUser WHERE UserName=@UserName AND UserPassw=@UserPassw");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            // Tanımlamalar
            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);

            // Değerler atanıyor

            sqlParameters[0].Value= userName;
            sqlParameters[1].Value= userPassw;

            return DBOperation.executeSelectQuery(Query, sqlParameters);
        }

        // Bir kullanıcıyı UserID sine göre aramak

        public DataTable getUser(int UserID)
        {
            string Query = string.Format("SELECT * FROM datUser WHERE UserID=@UserID");

            SqlParameter[] sqlParameters = new SqlParameter[1];

            // Tanımlamalar
            sqlParameters[0] = new SqlParameter("UserID", SqlDbType.TinyInt);

            // Değerler atanıyor

            sqlParameters[0].Value = UserID;

            return DBOperation.executeSelectQuery(Query, sqlParameters);
        }

        // Kullanıcı ekleme
        public bool insertUser(string UserName,string UserPassw,string Ad,string Soyad,string TCKimlik,int MudurlukID) 
        {
            string query;

            query = "INSERT INTO datUser ";
            query += "(UserName,UserPassw,Ad,Soyad,TCKimlik,MudurlukID) VALUES ";
            query += "(@UserName,@UserPassw,@Ad,@Soyad,@TCKimlik,@MudurlukID)";

            SqlParameter[] sqlParameters = new SqlParameter[6];

            // Tanımlamalar
            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);

            // Değerler atanıyor

            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad;
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;


            return DBOperation.executeInsertQuery(query, sqlParameters);
        }

        // Kullanıcı Güncelleme

        public bool updateUser(int UserID, string UserName, string UserPassw, string Ad, string Soyad, string TCKimlik, int MudurlukID)
        {
            string query;

            query = "UPDATE datUser SET ";
            query += "UserName=@UserName,";
            query += "UserPassw=@UserPassw,";
            query += "Ad=@Ad,";
            query += "Soyad=@Soyad,";
            query += "TCKimlik=@TCKimlik,";
            query += "MudurlukID=@MudurlukID ";
            query += "WHERE UserID=@UserID";

            SqlParameter[] sqlParameters = new SqlParameter[7];

            // Tanımlamalar
            sqlParameters[0] = new SqlParameter("UserName", SqlDbType.NVarChar);
            sqlParameters[1] = new SqlParameter("UserPassw", SqlDbType.NVarChar);
            sqlParameters[2] = new SqlParameter("Ad", SqlDbType.NVarChar);
            sqlParameters[3] = new SqlParameter("Soyad", SqlDbType.NVarChar);
            sqlParameters[4] = new SqlParameter("TCKimlik", SqlDbType.NVarChar);
            sqlParameters[5] = new SqlParameter("MudurlukID", SqlDbType.TinyInt);
            sqlParameters[6] = new SqlParameter("UserID", SqlDbType.TinyInt);

            // Değerler atanıyor

            sqlParameters[0].Value = UserName;
            sqlParameters[1].Value = UserPassw;
            sqlParameters[2].Value = Ad;
            sqlParameters[3].Value = Soyad;
            sqlParameters[4].Value = TCKimlik;
            sqlParameters[5].Value = MudurlukID;
            sqlParameters[6].Value = UserID;


            return DBOperation.executeUpdateQuery(query, sqlParameters);
        }

        // Kullanıcı Silme
        public bool deleteUser(int UserID)
        {
            string query;

            query = "DELETE datUser WHERE UserID="+ UserID.ToString();

            return DBOperation.executeDeleteQuery(query);
        }
    }
}

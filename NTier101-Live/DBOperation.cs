using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTier101_Live
{
    internal class DBOperation
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection Connection { get; set; }

        // Constructor
        public DBOperation()
        {
            dataAdapter = new SqlDataAdapter();
            Connection= new SqlConnection(@"Data Source=PHOKAIA\SS2019DE;Initial Catalog=NTier101DB;Integrated Security=True;TrustServerCertificate=True;"); // Home

            //Connection = new SqlConnection(@"Data Source=BASAE;Initial Catalog=NTier101DB;Integrated Security=True;TrustServerCertificate=True;"); // ArıBilgi
        }

        private SqlConnection openConnection()
        {
            // vt ile olan bağlantıyı açmak ve durumunu geriye döndürmek için kullanılıyor

            if (Connection.State==ConnectionState.Closed || Connection.State==ConnectionState.Broken)
            {
                Connection.Open();
            }

            return Connection;
        }

        // Klasik CRUD işlemleri

        //Read
        public DataTable executeSelectQuery(string _query, SqlParameter[] _parameters)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();

            dt = null;

            try
            {
                cmd.Connection = openConnection();
                cmd.CommandText = _query;
                cmd.Parameters.AddRange(_parameters);

                cmd.ExecuteNonQuery();

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(ds);

                dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());

                return null;
            }

            return dt; // table geri döndürülüyor.

        }

        // Insert
        public bool executeInsertQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(_parameters);
                dataAdapter.InsertCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;
            }

            return true;
        }

        // Update
        public bool executeUpdateQuery(string _query, SqlParameter[] _parameters)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(_parameters);
                dataAdapter.UpdateCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;
            }

            return true;
        }

        // Delete
        public bool executeDeleteQuery(string _query)
        {
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;

                dataAdapter.DeleteCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message.ToString());
                return false;
            }

            return true;
        }
    }
}

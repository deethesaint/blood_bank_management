using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private SqlConnection connection;

        public DatabaseConnection()
        {
            String connectionString = "Data Source=VUTHANHDUONG\\D_DB;Initial Catalog=bloodbank_database;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        { 
            get 
            {
                if (instance == null)
                    instance = new DatabaseConnection();
                return instance; 
            } 
        }

        public void Connect(String cs)
        {
            connection = new SqlConnection(cs);
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}

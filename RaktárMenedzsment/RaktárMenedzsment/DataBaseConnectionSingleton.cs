using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RaktárMenedzsment
{
    class DataBaseConnectionSingleton
    {
        private static DataBaseConnectionSingleton dataBaseConnectionInstance = null;
        private static MySqlConnection connection = null;
        private const string connectionString = "datasource=localhost;port=3306;Initial Catalog=plushwarehousedb;username=root;password=";
        public static MySqlConnection GetDatabaseConnectionInstance()
        {
            if(dataBaseConnectionInstance == null)
            {
                dataBaseConnectionInstance = new DataBaseConnectionSingleton();
            }
            return connection;
        }

        private DataBaseConnectionSingleton()
        {
            try
            {
                connection = new MySqlConnection(connectionString);                
            }
            catch(Exception ex)
            {

            }
        }

    }
}

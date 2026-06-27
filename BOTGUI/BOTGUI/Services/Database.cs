using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace BOTGUI.Services
{
    public class Database
    {
        private string connectionString =
            "server=localhost;database=CyberBotDB;uid=root;password=Tselapedi@12345@T;";

        public MySqlConnection GetConnection() 
        {
            return new MySqlConnection(connectionString);
        }
    }
}

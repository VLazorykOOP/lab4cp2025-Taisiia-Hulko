using MySql.Data.MySqlClient;

namespace BookStoreApp
{
    public class DB
    {
        private MySqlConnection connection;

        public DB()
        {
            // Заміни на свої дані доступу:
            string connectionString = "server=localhost;port=3306;username=root;password=muwuqing188;database=BookStore;";
            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}

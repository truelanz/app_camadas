using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DataAccesslayerConnection
    {
        private string _stringConnection;
        private MySqlConnection _connection;

        public DataAccesslayerConnection(string connectionData)
        {
            this._connection = new MySqlConnection();
            this._stringConnection = connectionData;
            this._connection.ConnectionString = connectionData;
        }

        public MySqlConnection ConnectionObj
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        public string ConnectionString
        {
            get { return this._stringConnection; }
            set { this._stringConnection = value; }
        }

        public void Connect()
        {
            this._connection.Open();
        }

        public void Close()
        {
            this._connection.Close();
        }
    }
}

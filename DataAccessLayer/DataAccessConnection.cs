using MySql.Data.MySqlClient;

//Classe/Camada de ACESSO AOS DADOS, DataAccess.
namespace DataAccessLayer
{
    public class DataAccessConnection
    {
        private string _stringConnection;
        private MySqlConnection _connection;

        public DataAccessConnection(string connectionData)
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

        public void Disconnect()
        {
            this._connection.Close();
        }
    }
}

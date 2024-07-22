using Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DataAccessUser
    {
        private DataAccessConnection connection;

        public DataAccessUser(DataAccessConnection connection)
        {
            this.connection = connection;
        }

        public bool addTo(ModelUser modelUser)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.connection.ConnectionObj;

            cmd.CommandText = "INSERT crud (user_name, age, sex) VALUES(@user_name, @age, @sex)";
            cmd.Parameters.AddWithValue("@user_name", modelUser.user_name);
            cmd.Parameters.AddWithValue("@age", modelUser.age);
            cmd.Parameters.AddWithValue("@sex", modelUser.sex);

            this.connection.Connect();
            this.connection.Disconnect();

            int result = cmd.ExecuteNonQuery();
            if (result <= 0)
                return false;
            return true;
        }

        public bool update(ModelUser modelUser)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.connection.ConnectionObj;

            cmd.CommandText = "UPDATE crud SET user_name=@user_name, age=@age, sex=@sex WHERE id_user=@id";
            cmd.Parameters.AddWithValue("@user_name", modelUser.user_name);
            cmd.Parameters.AddWithValue("@age", modelUser.age);
            cmd.Parameters.AddWithValue("@sex", modelUser.sex);
            cmd.Parameters.AddWithValue("@id", modelUser.id);

            this.connection.Connect();
            this.connection.Disconnect();

            int result = cmd.ExecuteNonQuery();
            if (result <= 0)
                return false;
            return true;
        }

        public void delete(int code)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.connection.ConnectionObj;

            cmd.CommandText = "DELETE FROM crud WHERE id_user=@id";
            cmd.Parameters.AddWithValue("@id", code);

            this.connection.Connect();
            cmd.ExecuteNonQuery();
            this.connection.Disconnect();

        }

        public DataTable dataList()
        {
            DataTable data = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * from crud", this.connection.ConnectionString);
            dataAdapter.Fill(data);
            return data;
        }
    }
}

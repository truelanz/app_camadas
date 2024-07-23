
using DataAccessLayer;
using Model;
using System;
using System.Data;

//Classe/Camada de regra de negócios/Business "Controllers"

namespace BusinessLogicLayer
{
    public class BusinessLogicUser
    {
        private DataAccessConnection connection;

        // Construtor
        public BusinessLogicUser(DataAccessConnection connection)
        {
            this.connection = connection;
        }

        public bool AddTo(ModelUser modelUser)
        {
            if (modelUser.user_name == "" || modelUser.age == "" || modelUser.sex =="")
                throw new Exception("Todos os campos devem ser obrigatórios");
            else
            {
                DataAccessUser dataAccessUser = new DataAccessUser(this.connection);
                bool result = dataAccessUser.AddTo(modelUser);

                if (result == false)
                    return false;
                else
                    return true;
            }

        }

        public bool Update(ModelUser modelUser)
        {
            if (modelUser.user_name == "" || modelUser.age == "" || modelUser.sex == "")
                throw new Exception("Todos os campos devem ser obrigatórios");
            else
            {
                DataAccessUser dataAccessUser = new DataAccessUser(this.connection);
                bool result = dataAccessUser.Update(modelUser);

                if (result == false)
                    return false;
                else
                    return true;
            }

        }

        public void Delete(int code)
        {
            DataAccessUser dataAccessUser = new DataAccessUser(this.connection);
            dataAccessUser.Delete(code);
        }

        public DataTable list()
        {
            DataAccessUser dataAccessUser = new DataAccessUser(this.connection);
            return dataAccessUser.DataList();
        }

    }
}

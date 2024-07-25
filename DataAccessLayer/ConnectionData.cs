using System;

//Classe/Camada de ACESSO AOS DADOS, DataAccess.
namespace DataAccessLayer
{
    public class ConnectionData
    {
        public static String StringConnection
        {
            get
            {
                return "Server = localhost; Database = crud; Uid = truelanz; pwd = 1234";
            }
        }
    }
}

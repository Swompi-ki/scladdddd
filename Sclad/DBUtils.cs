using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Sclad
{
    class DBUtils
    {
        //Подключение к базе данных в MeSQL
        public static MySqlConnection GetDBConnection()
        {
            string host = "192.168.4.9";
            int port = 3311;
            string database = "user5";
            string user = "user5";
            string password = "1234";

            return MySQLDBUtils.GetDBConnection(host, port, database, user, password);
        }
    }
}

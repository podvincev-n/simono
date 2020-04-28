using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectWork_Simonova_AV
{
    class DataBase 
    {
        MySqlConnection connection  = new MySqlConnection("server = localhost; port =  3306; username = root; password = root; database = spendplaner ") ; // подключение к БД

        public void openConnection() // открытие соединения с БД
        {
            if (connection.State == System.Data.ConnectionState.Closed)

                connection.Open();
        }
        public void closeConnection() // закрытие соединения с  БД
        {
            if (connection.State == System.Data.ConnectionState.Open)

                connection.Close();
        }

        public MySqlConnection getConnection() // возвращение соединения с БД
        {
            return connection;
        }

    }
}

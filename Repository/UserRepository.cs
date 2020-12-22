using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows;

namespace curse_work.Repository
{
    class UserRepository
    {
        public static bool Login(User user)
        {
            DB db = new DB();

            const string TABLE = "users";

            string query = $"SELECT login, password FROM {TABLE} WHERE login = '{user.Login}' AND password = '{user.Password}'";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            try
            {
                string login = reader.GetValue(0).ToString();
                string password = reader.GetValue(1).ToString();
            }
            catch (Exception e)
            {
                return false;
            }

            

            db.CloseConnection();

            return true;
        }
    }
}

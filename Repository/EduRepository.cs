using curse_work;
using cusrse_work_forth.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace cusrse_work_forth.Repository
{
    public class EduRepository
    {
        public static List<EduModel> GetAll()
        {
            var result = new List<EduModel>();

            var db = new DB();

            string table = "education";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new EduModel
                    (
                        Int32.Parse(reader.GetValue(0).ToString()),
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString(),
                        reader.GetValue(3).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
        }


        public static void Add(EduModel data)
        {
            var db = new DB();

            string query = $"INSERT education VALUES (null, '{data.Name}', '{data.Type}', '{data.Direction}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }


        public static void Delete(int id)
        {
            var db = new DB();

            string query = $"DELETE FROM education WHERE id = {id}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }
    }
}

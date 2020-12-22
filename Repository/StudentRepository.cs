using curse_work;
using cusrse_work_forth.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace cusrse_work_forth.Repository
{
    class StudentRepository
    {
        public static List<StudentModel> GetAll()
        {
            var result = new List<StudentModel>();

            var db = new DB();

            string table = "students";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new StudentModel
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


        public static void Add(StudentModel data)
        {
            var db = new DB();

            string query = $"INSERT students VALUES (null, '{data.Name}', '{data.Birthday}', '{data.School}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }


        public static void Delete(int id)
        {
            var db = new DB();

            string query = $"DELETE FROM students WHERE id = {id}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());
            command.ExecuteNonQuery();

            db.CloseConnection();
        }
    }
}

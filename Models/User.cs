using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Models
{
    public class User
    {
        public int Id;
        public string Login;
        public string Password;


        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}

using _160720.Infrastructure;
using _160720.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _160720.Services
{
    public class UserService : BaseService
    {

        public User Login(string username,string password)
        {
            User user = null;

            _connection.Open();

            string query = "SELECT * FROM Users WHERE [Username]=@username AND [Password]=@password";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                user = new User
                {
                    Id = reader.GetInt32(0),
                    Fullname = reader.GetString(1),
                    Username = reader.GetString(2),
                    Password = reader.GetString(3)
                };
            }

            _connection.Close();

            return user;
        }

    }
}

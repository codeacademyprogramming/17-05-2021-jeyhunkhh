using _160720.Infrastructure;
using _160720.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _160720.Services
{
    public class GroupService : BaseService
    {
        public List<Group> GetGroups()
        {
            List<Group> groups = new List<Group>();
            _connection.Open();

            string query = "SELECT * FROM Groups";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                groups.Add(new Group
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            _connection.Close();
            return groups;
        }
    }
}

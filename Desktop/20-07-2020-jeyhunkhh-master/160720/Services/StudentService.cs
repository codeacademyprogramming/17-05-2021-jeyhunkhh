using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using _160720.Infrastructure;
using _160720.Models;

namespace _160720.Services
{
    public class StudentService : BaseService
    {
        public void Insert(Student student)
        {
            if (student == null) throw new NullReferenceException();

            _connection.Open();

            string query = "INSERT INTO Students([Name],[Surname],[GroupId],[Birthday]) VALUES(@name,@surname,@groupId,@birthday)";

            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@groupId", student.GroupId);
            command.Parameters.AddWithValue("@birthday", student.Birthday);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            _connection.Open();

            string query = "SELECT * FROM Students s INNER JOIN Groups g ON s.GroupId = g.Id";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                students.Add(new Student
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Surname = reader.GetString(2),
                    GroupId = reader.GetInt32(3),
                    Birthday = reader.GetDateTime(4),
                    Group = new Group
                    {
                        Id = reader.GetInt32(6),
                        Name = reader.GetString(7)
                    }
                });
            }
            _connection.Close();

            return students;
        }

        public void Delete(int id)
        {
            _connection.Open();

            string query = "DELETE FROM Students WHERE [id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Student student)
        {
            _connection.Open();

            string query = "UPDATE Students SET [Name]=@name,[Surname]=@surname,[GroupId]=@groupId,[Birthday]=@birthday WHERE [Id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@groupId", student.GroupId);
            command.Parameters.AddWithValue("@birthday", student.Birthday);
            command.Parameters.AddWithValue("@id", student.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

using _150720.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _150720.Services
{
    class AirlineService : IRepository<Airline>
    {
        private readonly SqlConnection _connection;

        public AirlineService()
        {
            _connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=Airport;Trusted_Connection=True;");
        }

        public void Insert(Airline airline)
        {
            if (airline == null) throw new NullReferenceException();

            _connection.Open();

            string query = "INSERT INTO Airlines([Name],[Logo],[CountyId]) VALUES(@name,@logo,@countryId)";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", airline.Name);
            command.Parameters.AddWithValue("@logo", airline.Logo);
            command.Parameters.AddWithValue("@countryId", airline.CountryId);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public List<Airline> GetAll()
        {
            _connection.Open();

            string query = "SELECT * FROM Airlines a INNER JOIN Countries c ON a.CountyId=c.Id";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Airline> airlines = new List<Airline>();

            while (reader.Read())
            {
                Airline airline = new Airline
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Logo = reader.GetString(2),
                    CountryId = reader.GetInt32(3),
                    Country = new Country
                    {
                        Id = reader.GetInt32(4),
                        Name = reader.GetString(5)
                    }
                };

                airlines.Add(airline);
            }

            _connection.Close();

            return airlines;
        }

        public Airline GetById(int id)
        {
            _connection.Open();

            string query = "SELECT * FROM Airlines a INNER JOIN Countries c ON a.CountyId=c.Id WHERE a.Id=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            Airline airline = null;

            while (reader.Read())
            {
                airline = new Airline
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Logo = reader.GetString(2),
                    CountryId = reader.GetInt32(3),
                    Country = new Country
                    {
                        Id = reader.GetInt32(4),
                        Name = reader.GetString(5)
                    }
                };
            }

            _connection.Close();

            return airline;
        }

        public void Update(Airline airline)
        {
            _connection.Open();

            string query = "UPDATE Airlines SET [Name]=@name,[Logo]=@logo,[CountyId]=@countryId WHERE [Id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", airline.Name);
            command.Parameters.AddWithValue("@logo", airline.Logo);
            command.Parameters.AddWithValue("@countryId", airline.CountryId);
            command.Parameters.AddWithValue("@id", airline.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();

            string query = "DELETE FROM Airlines WHERE [Id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public bool CheckName(string name)
        {
            _connection.Open();

            string query = "SELECT COUNT(*) FROM Airlines WHERE [Name]=@name";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", name);

            int count = (int)command.ExecuteScalar();

            _connection.Close();

            if (count == 0) return true;

            return false;
        }
    }
}

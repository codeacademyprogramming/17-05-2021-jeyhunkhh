using _150720.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _150720.Services
{
    class CityService : IRepository<City>
    {
        private readonly SqlConnection _connection;

        public CityService()
        {
            _connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=Airport;Trusted_Connection=True;");
        }

        public void Insert(City city)
        {
            if (city == null) throw new NullReferenceException();

            _connection.Open();

            string query = "INSERT INTO Cities([Name],[CountryId]) VALUES(@name,@countryId)";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", city.Name);
            command.Parameters.AddWithValue("@countryId", city.CountryId);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public List<City> GetAll()
        {
            _connection.Open();

            string query = "SELECT * FROM Cities a INNER JOIN Countries c ON a.CountryId=c.Id";

            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<City> cities = new List<City>();

            while (reader.Read())
            {
                City city = new City
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(2),
                    CountryId = reader.GetInt32(1),
                    Country = new Country
                    {
                        Id = reader.GetInt32(3),
                        Name = reader.GetString(4)
                    }
                };

               cities.Add(city);
            }

            _connection.Close();

            return cities;
        }

        public City GetById(int id)
        {
            _connection.Open();

            string query = "SELECT * FROM Cities a INNER JOIN Countries c ON a.CountryId=c.Id WHERE a.Id=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();

            City city = null;

            while (reader.Read())
            {
                city = new City
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(2),
                    CountryId = reader.GetInt32(1),
                    Country = new Country
                    {
                        Id = reader.GetInt32(3),
                        Name = reader.GetString(4)
                    }
                };
            }

            _connection.Close();

            return city;
        }

        public void Update(City city)
        {
            _connection.Open();

            string query = "UPDATE Cities SET [Name]=@name,[CountryId]=@countryId WHERE [Id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", city.Name);
            command.Parameters.AddWithValue("@countryId", city.CountryId);
            command.Parameters.AddWithValue("@id", city.Id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            _connection.Open();

            string query = "DELETE FROM Cities WHERE [Id]=@id";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public bool CheckName(string name)
        {
            _connection.Open();

            string query = "SELECT COUNT(*) FROM Cities WHERE [Name]=@name";

            SqlCommand command = new SqlCommand(query, _connection);

            command.Parameters.AddWithValue("@name", name);

            int count = (int)command.ExecuteScalar();

            _connection.Close();

            if (count == 0) return true;

            return false;
        }
    }
}

using _150720.Models;
using _150720.Services;
using System;
using System.Data.Common;
using System.Data.SqlClient;

namespace _150720
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineService airlineService = new AirlineService();

            //Airline airline = new Airline
            //{
            //    Name = "S7",
            //    Logo = "S7",
            //    CountryId = 3
            //};

            //airlineService.Insert(airline);

            //foreach (Airline airline in airlineService.GetAll())
            //{
            //    Console.WriteLine("{0} {1} {2}", airline.Id, airline.Name, airline.Country.Name);
            //}

            //Airline airline = airlineService.GetById(7);

            //if(airline == null)
            //{
            //    Console.WriteLine("Hava yolu sirketi tapilmadi");
            //}

            //Airline airline = airlineService.GetById(7);

            //airline.Name = "Anadolu Airways";
            //airline.Logo = "Anadolu Airways";
            //airline.CountryId = 2;

            //airlineService.Update(airline);

            //airlineService.Delete(7);

            //Console.WriteLine(airlineService.CheckName("Anadolu Jet"));

            //CityService cityService = new CityService();

            //City city = cityService.GetById(4);

            //city.Name = "Ganja";

            //cityService.Update(city);
        }

        static void Insert()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=Airport;Trusted_Connection=True;");
            connection.Open();

            string query = "INSERT INTO Airlines([Name],[Logo],[CountyId]) VALUES(@name,@logo,@countryId)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@name", "Anadolu Jet");
            command.Parameters.AddWithValue("@logo", "Anadolu Jet");
            command.Parameters.AddWithValue("@countryId", 1);

            int rowAff = command.ExecuteNonQuery();

            connection.Close();

            if (rowAff == 1)
            {
                Console.WriteLine("Anadolu jet databazaya elave edildi");
            }
            else
            {
                Console.WriteLine("Tekrar sinayin bi xeta yarandi");
            }
        }

        static void GetAirlines()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=Airport;Trusted_Connection=True;");
            connection.Open();

            string query = "SELECT a.Id,a.Name,c.Name as Country FROM Airlines a INNER JOIN Countries c ON a.CountyId = c.Id";

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine("{0,5} {1,10} {2,-10}", "Id", "Name", "Country");

            while (reader.Read())
            {
                Console.WriteLine("{0,5} {1,10} {2,-10}", reader["Id"], reader["Name"], reader.GetString(2));
            }

            connection.Close();
        }

        static int GetCountOfTodayFlight()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-TNHKHHJ;Database=Airport;Trusted_Connection=True;");
            connection.Open();

            string query = "SELECT COUNT(*) FROM FlightItems WHERE [Date]=@date";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@date", DateTime.Today.ToString("yyyy-MM-dd"));

            int r = (int)command.ExecuteScalar();

            connection.Close();

            return r;
        }
    }
}

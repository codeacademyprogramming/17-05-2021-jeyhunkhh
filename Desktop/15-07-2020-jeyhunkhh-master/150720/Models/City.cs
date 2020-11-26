using System;
using System.Collections.Generic;
using System.Text;

namespace _150720.Models
{
    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.Hospital
{
    class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int[] WorkDays { get; set; }
        public Department Department { get; set; }

        public Doctor(string name,string surname,Department department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
        }
    }
}

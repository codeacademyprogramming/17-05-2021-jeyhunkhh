using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.Hospital
{
    class Department
    {
        public string Name { get; set; }
        public int Floor { get; set; }

        public Department(string name,int floor)
        {
            this.Name = name;
            this.Floor = floor;
        }
    }
}

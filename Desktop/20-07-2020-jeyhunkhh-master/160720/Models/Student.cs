using System;
using System.Collections.Generic;
using System.Text;

namespace _160720.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; }

        public Group Group { get; set; }
    }
}

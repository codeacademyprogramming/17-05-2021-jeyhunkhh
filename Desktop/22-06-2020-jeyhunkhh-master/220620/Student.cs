using System;
using System.Collections.Generic;
using System.Text;

namespace _220620
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public DateTime Birthday { get; set; }

        private int _age;
        public int Age => _age;

        public Student(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Student(string name, string surname, DateTime birthday)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;

            this.CalcAge();
        }

        private void CalcAge()
        {
            var diff = DateTime.Now.Subtract(this.Birthday);
            this._age = Convert.ToInt32(Math.Ceiling(diff.TotalDays / 365));
        }

        ~Student()
        {
            Console.WriteLine("Destructor was called");
        }
    }
}

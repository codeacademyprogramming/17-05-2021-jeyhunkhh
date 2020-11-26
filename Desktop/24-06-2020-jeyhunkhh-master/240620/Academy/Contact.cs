using System;
using System.Collections.Generic;
using System.Text;

namespace _240620.Academy
{
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Candidate : Contact
    {
        public string Email { get; set; }
        public bool HasWork { get; set; }
        public string Education { get; set; }
    }

    class Student : Candidate
    {
        public string Group { get; set; }
        public string PaymentCost { get; set; }
        public int PaymentCount { get; set; }
    }

    class Graduate : Student
    {
        public int Result { get; set; }
        public string MyProperty { get; set; }
    }
}

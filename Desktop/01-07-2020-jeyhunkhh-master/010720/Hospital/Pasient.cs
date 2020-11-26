using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.Hospital
{
    class Pasient
    {
        public int IdNumber { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodGroup { get; set; }

        public Pasient(string fullname,string phoneNumber)
        {
            this.Fullname = fullname;
            this.PhoneNumber = phoneNumber;
        }
    }
}

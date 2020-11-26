using System;
using System.Collections.Generic;
using System.Text;

namespace _010720.Hospital
{
    enum MeetingType
    {
        Checkup,
        Procedure,
        Operation
    }
    class Meeting
    {
        public MeetingType Type { get; set; }
        public Pasient Pasient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
        public string Result { get; set; }

        public override string ToString()
        {
            return $"{Pasient.Fullname} '{Complaint}' sikayeti ile {Date.ToString("HH:mm dd.MM.yyyy")} tarixinde {Doctor.Name} {Doctor.Surname} terefinden {Type.ToString()} gorusunde olub, '{Diagnosis}' diaqnozu qoyulub ve '{Result}' mulicesi yazilib";
        }
    }
}

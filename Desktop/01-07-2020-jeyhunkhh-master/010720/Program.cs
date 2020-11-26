using _010720.Hospital;
using _010720.School;
using System;

namespace _010720
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = { 17, 28, 38, 21, 32 };

            //Array.Clear(ages, 0, 3);

            //Array.Resize(ref ages, 4);

            //ages.Length ages.Rank

            //int[] ages2 = new int[ages.Length];

            //Array.Copy(ages, ages2, ages.Length);

            //Array.Sort(ages);
            //Array.Reverse(ages);

            //Array.IndexOf(ages, 91);

            //int[,] data = new int[19,25];

            //int count = 1;

            //for (int i = 0; i < data.GetLength(0); i++)
            //{
            //    for (int j = 0; j < data.GetLength(1); j++)
            //    {
            //        Console.WriteLine(count+" : " +data[i,j]);
            //        count++;
            //    }
            //}


            //Student[] sinif = new Student[3];

            //sinif[0] = new Student
            //{
            //    Name = "Saleh",
            //    Surname = "Haciyev"
            //};

            //sinif[1] = new Student
            //{
            //    Name = "Gubad",
            //    Surname = "Mustafeyv"
            //};

            //sinif[2] = new Student
            //{
            //    Name = "Kamil",
            //    Surname = "Hasanov"
            //};

            //foreach (Student item in sinif)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //Teacher teacher = new Teacher("Aytac Zulfugarova");

            //teacher.AddLesson(5, 10);
            //teacher.AddLesson(7, 4);
            //teacher.AddLesson(11, 5);
            //teacher.AddLesson(10, 4);

            //teacher.RemoveLesson(1);

            //Console.WriteLine(teacher.Salary);


            Department cardiology = new Department("Kardiologiya", 3);
            Department neurology = new Department("Nevrologiya", 2);

            Doctor aysel = new Doctor("Aysel", "Islamli", cardiology);
            Doctor ruslan = new Doctor("Ruslan", "Bağıyev", cardiology);
            Doctor sabina = new Doctor("Sabina", "Aslan", neurology);
            Doctor vafa = new Doctor("Vafa", "Ismayilova", neurology);

            Pasient yolchu = new Pasient("Yolchu Nasib", "0556298878");
            Pasient jeyhun = new Pasient("Jeyhun Huseynov", "0513980332");

            Meeting meeting = new Meeting
            {
                Type = MeetingType.Checkup,
                Pasient = yolchu,
                Doctor = aysel,
                Date = new DateTime(2020, 07, 01, 12, 0, 0),
                Complaint = "Ureyim agriyir ay doxtur",
                Diagnosis = "Ureyinde xal var",
                Result = "Xali yox etmek ucun derman yazdiq"
            };

            Meeting meeting1 = new Meeting
            {
                Type = MeetingType.Checkup,
                Pasient = jeyhun,
                Doctor = sabina,
                Date = new DateTime(2020, 06, 30, 14, 30, 0),
                Complaint = "Nece aydi saxtakarliq ede bilmirem",
                Diagnosis = "Siz olufsunuz",
                Result = "Dirilmesi ucun iyne yazdiq"
            };

            Console.WriteLine(meeting.Doctor.Department.Name);
            Console.WriteLine("============================");
            Console.WriteLine(meeting1.Doctor.Department.Name);
        }
    }
}

using System;

namespace _170920
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string a = student.Fullname();

            int result = student.Topla(34,27);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

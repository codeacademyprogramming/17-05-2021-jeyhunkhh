using System;

namespace _220620
{
    class Program
    {
        static void Main(string[] args)
        {
            Modem modem = new Modem("My Wifi", "123123");

            modem.Connect("123123"); // device 1
            modem.Connect("123123"); // device 2

            modem.ChangePassword("123123", "123456");

            modem.Connect("123456"); // device 3
            modem.Connect("123456"); // device 4
            modem.Connect("123456"); // device 5
            modem.Disconnect(); // device 4
            modem.Disconnect(); // device 3
            modem.Connect("123456"); // device 4

            Console.WriteLine("Capacity : " + modem.Capacity);
            Console.WriteLine("Connected device : " + modem.ConnectionCount);
        }
    }
}

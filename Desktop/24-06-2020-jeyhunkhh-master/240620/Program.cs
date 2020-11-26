using _240620.Academy;
using _240620.Zoo;
using System;

namespace _240620
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Json");
            Console.WriteLine(dog.Name);

            Dog dog1 = new Dog("Css");
            Console.WriteLine(dog1.Name);

            Cat cat = new Cat("Sass");
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Sound());


            //Gun gun = new Gun(30);
            //Console.WriteLine("===========================================");
            //Console.WriteLine("                 Gun App                   ");
            //Console.WriteLine("===========================================");

            //int selection;
            //do
            //{

            //    Console.WriteLine("===========================================");
            //    Console.WriteLine(gun.ToString());
            //    Console.WriteLine("===========================================");

            //    Console.WriteLine("1. Shoot");
            //    Console.WriteLine("2. Reload");
            //    Console.WriteLine("3. Add Pistol");
            //    Console.WriteLine("4. Change Mode");
            //    Console.WriteLine("0. Exit");

            //    Console.WriteLine("===========================================");
            //    string selectionStr = Console.ReadLine();

            //    while (!int.TryParse(selectionStr, out selection))
            //    {
            //        Console.WriteLine("Düzgün seçim edin");
            //        selectionStr = Console.ReadLine();
            //    }

            //    switch (selection)
            //    {
            //        case 1:
            //            Console.WriteLine("===========================================");
            //            Console.WriteLine("You select shoot");
            //            Console.WriteLine("===========================================");

            //            bool r = gun.Shoot();

            //            if (!r)
            //            {
            //                Console.WriteLine("You have no pistol");
            //            }

            //            Console.WriteLine("===========================================");
            //            break;
            //        case 2:
            //            Console.WriteLine("===========================================");
            //            Console.WriteLine("You select reload");
            //            Console.WriteLine("===========================================");

            //            gun.Reload();

            //            Console.WriteLine("===========================================");
            //            break;
            //        case 3:
            //            Console.WriteLine("===========================================");
            //            Console.WriteLine("You select add pistol");
            //            Console.WriteLine("===========================================");
            //            Console.WriteLine("Elave etmek isteyiniz gulle sayi yazin");

            //            string pistolStr = Console.ReadLine();

            //            int pistolCount;
            //            while (!int.TryParse(pistolStr, out pistolCount))
            //            {
            //                Console.WriteLine("Duzgun litr yazin");
            //                pistolStr = Console.ReadLine();
            //            }

            //            gun.AddPistol(pistolCount);

            //            Console.WriteLine("===========================================");
            //            break;
            //        case 4:
            //            Console.WriteLine("===========================================");
            //            Console.WriteLine("You select change mode");
            //            Console.WriteLine("===========================================");

            //            gun.ChangeMode();

            //            Console.WriteLine("===========================================");
            //            break;
            //        case 0:
            //            break;
            //        default:
            //            Console.WriteLine("Duzgun secim etmediniz");
            //            Console.WriteLine("===========================================");
            //            break;
            //    }

            //} while (selection != 0);
        }
    }
}

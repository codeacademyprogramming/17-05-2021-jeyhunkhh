using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(6, 70);

            Console.WriteLine("===========================================");
            Console.WriteLine("                 Car App                   ");
            Console.WriteLine("===========================================");

            int selection;
            do
            {
                Console.WriteLine("1. Drive");
                Console.WriteLine("2. Add Fuel");
                Console.WriteLine("3. Local Km");
                Console.WriteLine("4. Global Km");
                Console.WriteLine("5. Reset Local Km");
                Console.WriteLine("0. Exit");

                Console.WriteLine("===========================================");
                string selectionStr = Console.ReadLine();

                while (!int.TryParse(selectionStr, out selection))
                {
                    Console.WriteLine("Düzgün seçim edin");
                    selectionStr = Console.ReadLine();
                }

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("You select drive");
                        Console.WriteLine("===========================================");

                        Console.WriteLine("Surmek istedyiniz km yazin");
                        string kmStr = Console.ReadLine();

                        double km;
                        while (!double.TryParse(kmStr, out km))
                        {
                            Console.WriteLine("Duzgun km yazin");
                            kmStr = Console.ReadLine();
                        }

                        bool r = car.Drive(km);

                        if (r)
                        {
                            Console.WriteLine($"Siz masini {km:0.00} km surdunuz, movcud yanacaq {car.CurrentFuel:0.00} litrdir");
                        }
                        else
                        {
                            double canDriveKm = car.CurrentFuel / car.FuelUsage * 100;
                            Console.WriteLine($"Masini {km:0.00} km sure bilmesiniz, movcud yanacaqla {canDriveKm:0.00} km sure bilersiniz");
                        }

                        Console.WriteLine("===========================================");
                        break;
                    case 2:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("You select add fuel");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Elave etmek isteyiniz litr yazin");

                        string litrStr = Console.ReadLine();

                        double litr;
                        while (!double.TryParse(litrStr, out litr))
                        {
                            Console.WriteLine("Duzgun litr yazin");
                            litrStr = Console.ReadLine();
                        }

                        bool addFuelResult = car.AddFuel(litr);

                        if (addFuelResult)
                        {
                            Console.WriteLine($"{litr:0.00} litr yanacaq elave olunudu, movcud yanacaq {car.CurrentFuel:0.00} litrdir");
                        }
                        else
                        {
                            double canAddLitr = car.FuelCapacity - car.CurrentFuel;
                            Console.WriteLine($"{litr:0.00} litr yanacaq elave ede bilmezsiniz, maxiumum {canAddLitr:0.00} litr elave ede bilersiniz");
                        }
                        Console.WriteLine("===========================================");
                        break;
                    case 3:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("You select local km");
                        Console.WriteLine("===========================================");

                        Console.WriteLine($"Sizin local km-iniz : {car.LocalKm:0.00}");
                        break;
                    case 4:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("You select global km");
                        Console.WriteLine("===========================================");

                        Console.WriteLine($"Sizin global km-iniz : {car.GlobalKm:0.00}");
                        Console.WriteLine("===========================================");
                        break;
                    case 5:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("You select reset local km");
                        Console.WriteLine("===========================================");

                        car.ResetLocalKm();

                        Console.WriteLine("Local km sifirlandi");
                        Console.WriteLine("===========================================");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Duzgun secim etmediniz");
                        Console.WriteLine("===========================================");
                        break;
                }

            } while (selection != 0);

        }

        //static void Main(string[] args)
        //{
        //    AirCondition airCondition = new AirCondition();

        //    airCondition.Mode = AirConditionMode.Summer;
        //    airCondition.FanDirection = FanDirection.Middle;
        //}
    }
}

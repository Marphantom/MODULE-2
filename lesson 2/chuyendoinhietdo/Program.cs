using System;

namespace chuyendoinhietdo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double fah;
            double cel;

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Fah:");
                        fah = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Cel is {fahToCel(fah)}");
                        break;

                    case 2:
                        Console.WriteLine("Enter Cel:");
                        cel = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Fah is :{celToFaf(cel)}");
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
            while (choice != 0);
        }

        static double celToFaf(double cel)
        {
            double fah = (9.0 / 5) * cel + 32;
            return fah;
        }

        static double fahToCel(double fah)
        {
            double cel = (5.0 / 9) * (fah - 32);
            return cel;
        }
    }
}

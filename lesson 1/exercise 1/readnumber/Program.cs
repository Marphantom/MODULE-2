using System;

namespace readnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            double myNumber = double.Parse(Console.ReadLine());
            double hunderd = Math.Floor(myNumber / 100);
            double tens = Math.Floor((myNumber % 100) / 10);
            double ones = Math.Floor((myNumber % 100) % 10);

            switch (hunderd)
            {
                case 1:
                    if (tens == 0 && ones == 0)
                    {
                        Console.Write("one hunderd");
                    }
                    else
                    {
                        Console.Write("one hunderd and ");
                    }
                    break;
                case 2:
                    Console.Write("two hunderd and ");
                    break;
                case 3:
                    Console.Write("three hunderd and ");
                    break;
                case 4:
                    Console.Write("four hunderd and ");
                    break;
                case 5:
                    Console.Write("five hunderd and ");
                    break;
                case 6:
                    Console.Write("six hunderd and ");
                    break;
                case 7:
                    Console.Write("seven hunderd and ");
                    break;
                case 8:
                    Console.Write("eight hunderd and ");
                    break;
                case 9:
                    Console.Write("nine hunderd and ");
                    break;
            }

            switch (tens)
            {
                case 0:
                    break;
                case 1:
                    switch (ones)
                    {
                        case 0:
                            Console.Write("Tenth ");
                            break;
                        case 1:
                            Console.Write("Eleventh ");
                            break;
                        case 2:
                            Console.Write("Twelfth ");
                            break;
                        case 3:
                            Console.Write("Thirteenth ");
                            break;
                        case 4:
                            Console.Write("Fourteenth ");
                            break;
                        case 5:
                            Console.Write("Fifteenth ");
                            break;
                        case 6:
                            Console.Write("Sixteenth ");
                            break;
                        case 7:
                            Console.Write("Seventeenth ");
                            break;
                        case 8:
                            Console.Write("Eighteenth ");
                            break;
                        case 9:
                            Console.Write("Nineteenth ");
                            break;
                    }
                    break;
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Forty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty ");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
            }
            switch (ones)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }
        }
    }
}

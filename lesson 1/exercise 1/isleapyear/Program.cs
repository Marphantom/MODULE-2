using System;

namespace isleapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeapYear = false;

            Console.WriteLine("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else 
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }

    }
}

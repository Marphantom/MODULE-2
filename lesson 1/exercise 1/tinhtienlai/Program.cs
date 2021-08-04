using System;

namespace tinhtienlai
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int month;
            double intersetRate;

            Console.WriteLine("Enter investmen amount: ");
            money = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter annual interest rate in percentage: ");
            intersetRate = Double.Parse(Console.ReadLine());


            double totalInterset = 0;
            for(int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate/100)/12* month;
            }

            Console.WriteLine($"Total of interset: {totalInterset}");
        }
    }
}

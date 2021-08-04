using System;

namespace changeUSDToVND
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter USD: ");
            int USD = int.Parse(Console.ReadLine());
            int VND = 23000 * USD;

            Console.WriteLine($"USD to VND: {VND} dong");
        }
    }
}

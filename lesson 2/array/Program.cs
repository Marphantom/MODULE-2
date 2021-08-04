using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers ={2,5,9,6,7};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine($"Tong cua mang la: {total}");
        }
    }
}

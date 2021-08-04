using System;

namespace find20Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());

            for (int count = 0; count < myNumber; count++)
            {
                for (int n = 2; n <= myNumber; n++)
                {
                    if (count%n == 0)
                    {
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}

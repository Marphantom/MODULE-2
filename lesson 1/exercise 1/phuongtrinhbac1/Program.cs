using System;

namespace phuongtrinhbac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter B: ");
            int b = Int32.Parse(Console.ReadLine()); 

            if( a != 0)
            {
                int x = -b/a ;
                Console.WriteLine($"The solution is: {x}");
            }
            else
            {
                if (b == 0)
                {
                    Console.Write("The solution is all x!");
                }
                else
                {
                    Console.Write("Nod solution!");
                }
            }
        }
    }
}

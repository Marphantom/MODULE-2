using System;

namespace phuongtrinhbac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number A:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number B:");
            double numberB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number C:");
            double numberC = double.Parse(Console.ReadLine());

            Console.WriteLine($"{numberA}x2 + {numberB}x + {numberC} = 0");

            QuadraticEquation delta = new QuadraticEquation(numberA, numberB, numberC);

            if (delta.GetDiscriminant() < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta.GetDiscriminant() == 0)
            {
                Console.WriteLine($"Phuong trinh co 1 nghiem: {delta.GetRoot3()}");
            }
            else if (delta.GetDiscriminant() > 0)
            {
                Console.WriteLine($"Phuong trinh co 2 nghiem: {delta.GetRoot1()} va {delta.GetRoot2()}");
            }

        }
    }
}

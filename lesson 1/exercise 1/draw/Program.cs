using System;

namespace draw
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the rectangle");
                Console.WriteLine("2. Draw the triangle bottom left");
                Console.WriteLine("3. Draw the triangle top left");
                Console.WriteLine("4. Draw the triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the rectangle");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 7; j++)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.Write("\n");
                        break;

                    case 2:
                        Console.WriteLine("Draw the triangle bottom left");
                        for (int i = 1; i <= 7; i++)
                        {
                            for (int j = 1; j <= i; j++)
                                Console.Write("*");
                            Console.Write("\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Draw the triangle bottom top");
                        for (int i = 7; i > 0; i--)
                        {
                            for (int j = 1; j <= 2 * i - 1; j++)
                                Console.Write("*");
                            Console.Write("\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("4. Draw the triangle");
                        for (int i = 0; i < 7; i++)
                        {
                            for (int j = 1; j <= 7 - i; j++)
                                Console.Write(" ");
                            for (int j = 1; j <= 2 * i - 1; j++)
                                Console.Write("*");
                            Console.Write("\n");
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
        }
    }
}

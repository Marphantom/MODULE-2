using System;

namespace areaAndPerimeter
{
    class Program
    {
        private const int circle = 1;
        private const int square = 2;
        private const int rectangle = 3;
        private const int triangle = 4;
        private const int exitCode = 5;
        private const int area = 1;
        private const int perimeter = 2;
        private const int back = 3;
        private const int min = 1;
        private const int max = 5;
        static void Main(string[] args)
        {
            Process();
        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== AREA AND PERIMETER ==========");
                Console.WriteLine("1. circle");
                Console.WriteLine("2. square");
                Console.WriteLine("3. rectangle");
                Console.WriteLine("4. triangle");
                Console.WriteLine("5. Exit");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");
                // int.TryParse(Console.ReadLine(), out selected);
                selected = Int32.Parse(Console.ReadLine());
            }
            while (selected < min || selected > max);
        }

        private static void BuildChildMenu(out int choice)
        {
            do
            {
                Console.WriteLine("========== AREA AND PERIMETER ==========");
                Console.WriteLine("1. Area");
                Console.WriteLine("2. perimeter");
                Console.WriteLine("3. back");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");

                choice = Int32.Parse(Console.ReadLine());
            }
            while (choice < 1 || choice > 3);
        }

        public static void Process()
        {
            int selected = 0;
            do
            {
            change:
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case circle:
                        {
                            int choice = 0;
                            do
                            {
                                BuildChildMenu(out choice);
                                Console.Clear();
                                switch (choice)
                                {
                                    case area:
                                        {
                                            double radius = EnterNumber("Enter radius:");
                                            Console.WriteLine((radius * radius) * Math.PI);
                                            break;
                                        }

                                    case perimeter:
                                        {
                                            double radius = EnterNumber("Enter radius:");
                                            Console.WriteLine((radius * 2) * Math.PI);
                                            break;
                                        }

                                    case back:
                                        {
                                            goto change;
                                        }
                                }
                            }
                            while (choice != 3);
                            break;
                        }
                    case square:
                        {
                            int choice = 0;
                            do
                            {
                                BuildChildMenu(out choice);
                                Console.Clear();
                                switch (choice)
                                {
                                    case area:
                                        {
                                            double side = EnterNumber("Enter side:");
                                            Console.WriteLine(side * side);
                                            break;
                                        }

                                    case perimeter:
                                        {
                                            double side = EnterNumber("Enter side:");
                                            Console.WriteLine(side * 4);
                                            break;
                                        }

                                    case back:
                                        {
                                            goto change;
                                        }
                                }
                            }
                            while (choice != 3);
                            break;
                        }
                    case rectangle:
                        {
                            int choice = 0;
                            do
                            {
                                BuildChildMenu(out choice);
                                Console.Clear();
                                switch (choice)
                                {
                                    case area:
                                        {
                                            double width = EnterNumber("Enter width:");
                                            double height = EnterNumber("Enter height");
                                            Console.WriteLine(width * height);
                                            break;
                                        }

                                    case perimeter:
                                        {
                                            double width = EnterNumber("Enter width:");
                                            double height = EnterNumber("Enter height");
                                            Console.WriteLine((width + height) * 2);
                                            break;
                                        }

                                    case back:
                                        {
                                            goto change;
                                        }
                                }
                            }
                            while (choice != 3);
                            break;
                        }
                    case triangle:
                        {
                            int choice = 0;
                            do
                            {
                                BuildChildMenu(out choice);
                                Console.Clear();
                                switch (choice)
                                {
                                    case area:
                                        {
                                            double baseTriagle = EnterNumber("Enter baseTriagle:");
                                            double height = EnterNumber("Enter height");
                                            Console.WriteLine((baseTriagle * height) / 2);
                                            break;
                                        }

                                    case perimeter:
                                        {
                                            double sideA = EnterNumber("Enter sideA:");
                                            double sideB = EnterNumber("Enter sideB:");
                                            double sideC = EnterNumber("Enter sideC:");
                                            Console.WriteLine(sideA + sideB + sideC);
                                            break;
                                        }

                                    case back:
                                        {
                                            goto change;
                                        }
                                }
                            }
                            while (choice != 3);
                            break;
                        }
                    case exitCode:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != exitCode);
        }

        public static double EnterNumber(string msg)
        {
            double number = 0;
            bool isNumber = true;
            do
            {
                Console.Write(msg);
                isNumber = double.TryParse(Console.ReadLine(), out number);
            }
            while (!isNumber);
            return number;
        }
    }
}

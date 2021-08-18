using System;
using System.Collections;
using System.Collections.Generic;

namespace AnimalManagement
{
    class Program
    {
        static public Test t = new Test();
        static void Main(string[] args)
        {
            Process();
        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== CALCULATOR ==========");
                Console.WriteLine("1. Create a Crocodile");
                Console.WriteLine("2. Create a Cat");
                Console.WriteLine("3. Create a Fish");
                Console.WriteLine("4. View Terrestrial Animals");
                Console.WriteLine("5. View Marine Animals");
                Console.WriteLine("6. View all Animals");
                Console.WriteLine("7. Delete Animal");
                Console.WriteLine("8. Exit");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            }
            while (selected < 1 || selected > 8);
        }

        public static void Process()
        {
            int selected = 0;
            do
            {
                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {
                            t.AddCrocodile();
                            break;
                        }
                    case 2:
                        {
                            t.AddCat();
                            break;
                        }
                    case 3:
                        {
                            t.AddFish();
                            break;
                        }
                    case 4:
                        {
                            t.ViewTerrestrialAnimal();
                            break;
                        }
                    case 5:
                        {
                            t.ViewMarineAnimal();
                            break;
                        }
                    case 6:
                        {
                            t.ViewAllAnimal();
                            break;
                        }
                    case 7:
                        {
                            t.DeletaAnimal();
                            break;
                        }
                    case 8:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 8);
        }
    }
}

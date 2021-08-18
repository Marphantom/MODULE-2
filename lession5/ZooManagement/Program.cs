using System;

namespace ZooManagement
{
    class Program
    {
        private static Zoo myzoo = new Zoo();
        private static Cage mycage = new Cage();
        static void Main(string[] args)
        {
            // Tiger tiger = new Tiger("PhanTom", 5, "hello");
            // // tiger.Speak();

            // Cage cage1 = new Cage();
            // cage1.AddAnimal(tiger);
            // cage1.IterateAnimal();
            // cage1.RemoveAnimal(tiger.Name);
            // Zoo myZoo = new Zoo();

            // Cage cage1 = new Cage();
            // cage1.CageNumber = 1;
            // Tiger tiger1 = new Tiger("Ho mat seo", 2, "dau gau truong mau giao");
            // cage1.AddAnimal(tiger1);
            // Dog dog1 = new Dog("pug", 2, "dan choi xom");
            // cage1.AddAnimal(dog1);
            // myZoo.AddCage(cage1);

            // Cage cage2 = new Cage();
            // cage2.CageNumber = 2;
            // Tiger tiger2 = new Tiger("Ho mat seo", 2, "dau gau truong mau giao");
            // cage2.AddAnimal(tiger2);
            // Cat cat1 = new Cat("tom", 2, "dan choi xom");
            // cage2.AddAnimal(cat1);
            // myZoo.AddCage(cage2);

            // myZoo.ShowZooInfo();
            // myZoo.RemoveCage(3);
            // myZoo.ShowZooInfo();
            
            Process();


        }

        private static void BuildMenu(out int selected)
        {
            do
            {
                Console.WriteLine("========== CALCULATOR ==========");
                Console.WriteLine("1. Add cage");
                Console.WriteLine("2. Remove cage");
                Console.WriteLine("3. Add Animal");
                Console.WriteLine("4. Remove Animal");
                Console.WriteLine("5. show ");
                Console.WriteLine("6. Exit");
                Console.WriteLine("================================");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out selected);
            }
            while (selected < 1 || selected > 6);
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
                            myzoo.AddCage();
                            break;
                        }
                    case 2:
                        {
                            myzoo.RemoveCage();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter number cage: ");
                            int numberCage = int.Parse(Console.ReadLine());
                            foreach (Cage cage in myzoo.CageList)
                            {
                                if (cage.CageNumber == numberCage)
                                {
                                    cage.AddAnimal();
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter number cage: ");
                            int numberCage = int.Parse(Console.ReadLine());
                            foreach (Cage cage in myzoo.CageList)
                            {
                                if (cage.CageNumber == numberCage)
                                {
                                    cage.RemoveAnimal();
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            myzoo.ShowZooInfo();
                            break;
                        }
                    case 6:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 6);
        }
    }
}

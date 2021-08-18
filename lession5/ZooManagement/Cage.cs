using System;

namespace ZooManagement
{
    public class Cage
    {
        public int CageNumber { get; set; }
        public Animal[] AnimalList = new Animal[0];

        public void AddAnimal()
        {
            Console.WriteLine("1. Add Tiger");
            Console.WriteLine("2. Add Dog");
            Console.WriteLine("3. Add Cat");
            Console.WriteLine("======================");
            Console.WriteLine("Choose an animal: ");
            var selected = Int32.Parse(Console.ReadLine());
            switch (selected)
            {
                case 1:
                    Console.WriteLine("Enter tiger name: ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Enter tiger age: ");
                    var age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter tiger description: ");
                    var des = Console.ReadLine();
                    Animal tiger = new Tiger(name, age, des);
                    Array.Resize(ref AnimalList, AnimalList.Length + 1);
                    AnimalList[AnimalList.Length - 1] = tiger;
                    break;
                case 2:
                    Console.WriteLine("Enter dog name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter dog age: ");
                    age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter dog description: ");
                    des = Console.ReadLine();
                    Animal dog = new Dog(name, age, des);
                    Array.Resize(ref AnimalList, AnimalList.Length + 1);
                    AnimalList[AnimalList.Length - 1] = dog;
                    break;
                case 3:
                    Console.WriteLine("Enter cat name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter cat age: ");
                    age = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter cat description: ");
                    des = Console.ReadLine();
                    Animal cat = new Cat(name, age, des);
                    Array.Resize(ref AnimalList, AnimalList.Length + 1);
                    AnimalList[AnimalList.Length - 1] = cat;
                    break;
            }
        }

        public void RemoveAnimal()
        {
            Console.Write("Enter name animal: ");
            string name = Console.ReadLine();
            int position = -1;
            for (int i = 0; i < AnimalList.Length; i++)
            {
                if (string.Compare(AnimalList[i].Name.ToLower(), name.ToLower()) == 0)
                {
                    position = i;
                    break;
                }
            }
            if (position == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                for (int i = position; i < AnimalList.Length - 1; i++)
                {
                    AnimalList[i] = AnimalList[i + 1];
                }
                Array.Resize(ref AnimalList, AnimalList.Length - 1);
            }
            foreach (var anim in AnimalList)
            {
                anim.ViewInfo();
                anim.Speak();
            }

        }

        public void IterateAnimal()
        {
            foreach (var anim in AnimalList)
            {
                anim.ViewInfo();
                anim.Speak();
            }
        }
    }
}
using System;

namespace AnimalManagement
{
    public class Cat : ITerrestrialAnimal
    {
        int id;
        string name;
        int age;

        public int ID 
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public void Move()
        {
            Console.WriteLine("run");
        }

        public override string ToString()
        {
            Console.WriteLine(GetType());
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            return "";
        }
    }
}
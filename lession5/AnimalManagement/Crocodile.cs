using System;

namespace AnimalManagement
{
    public class Crocodile : ITerrestrialAnimal, IMarineAnimal
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

        void ITerrestrialAnimal.Move()
        {
            Console.WriteLine("Run");
        }

        void IMarineAnimal.Move()
        {
            Console.WriteLine("Swim");
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
using System;

namespace Animal
{
    public class Dog : Animal
    {
        private string Name {get; set;}

        public Dog(string weight, string height, string name) : base (weight,height)
        {
            this.Name = name;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Weight: {Weight}, Height: {Height}, Name: {Name}");
        }
    }
}
using System;

namespace ZooManagement
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string description) : base(name, age, description)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Gauu Gauu");
        }
    }
}
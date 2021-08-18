using System;

namespace ZooManagement
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string description) : base(name, age, description)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Meooo Meooo");
        }
    }
}
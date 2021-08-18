using System;

namespace ZooManagement
{
    public class Tiger : Animal
    {
        public Tiger(string name, int age, string description) : base(name, age, description)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Roarrrrrrr");
        }
    }
}
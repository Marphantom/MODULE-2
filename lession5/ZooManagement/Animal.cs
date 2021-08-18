using System;

namespace ZooManagement
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.Name = name;
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Animal(string name, int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }

        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}\t\tAge: {Age}\t\tDescription: {Description} ");
        }
        public abstract void Speak();

    }
}
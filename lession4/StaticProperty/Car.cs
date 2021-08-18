using System;

namespace StaticProperty
{
    public class Car
    {
        private string name;
        private string engine;
        public static int numberOfCars;

        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        // public string Engine
        // {
        //     get => engine;
        //     set => engine = value;
        // }
    }
}
using System;

namespace MyCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle hinhtron = new Circle(5,"red");
            Cylinder cylinder = new Cylinder(8,"white",12);

            Console.WriteLine(hinhtron.ToString());
            Console.WriteLine(cylinder.ToString());
            Console.WriteLine(cylinder.TheTich());
        }
    }
}

using System;

namespace rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width,height);
            Console.WriteLine("Area: " + rectangle.getArea());
            Console.WriteLine("Perimeter: "+ rectangle.getPrimeter());
            Console.WriteLine(rectangle.display());
        }
    }
}

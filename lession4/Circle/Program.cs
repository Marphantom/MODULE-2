using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCircle circle = new TestCircle(3, "blue");
            TestCircle circle1 = new TestCircle();
            circle1.GetRadius = 5.5;
            circle1.GetColor = "violet";

            circle.Display();
            circle1.Display();
        }
    }
}

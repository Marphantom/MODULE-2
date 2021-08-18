using System;

namespace Circle
{
    public class TestCircle
    {
        private double Radius = 1;
        private string Color = "red";

        public TestCircle()
        {
            
        }

        public TestCircle(double r, string c)
        {
            this.Radius = r;
            this.Color = c;
        }

        public double GetRadius
        {
            get => Radius;
            set => Radius = value;
        }

        public string GetColor
        {
            get => Color;
            set => Color = value;
        }

        public void Display()
        {
            Console.WriteLine($"Radius: {Radius}, Color: {Color}");
        }
    }
}
using System;

namespace MyCircle
{
    public class Circle
    {
        protected double Radius {get; set;}
        protected string Color {get; set;}

        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }

        public override string ToString()
        {
            return $"Circle have radius: {Radius} and coler: {Color}";
        }
    }
}
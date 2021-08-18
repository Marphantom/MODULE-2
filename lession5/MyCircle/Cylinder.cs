using System;

namespace MyCircle
{
    public class Cylinder : Circle
    {
        private double Height {get;set;}

        public Cylinder(double radius, string color, double height) : base (radius,color)
        {
            this.Height = height;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Height: {Height}";
        }

        public double TheTich()
        {
            return  Math.PI * (Radius*Radius) * Height;
        }
    }
}
using System;

namespace QuadraticEquation
{
    public class Discriminant
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Discriminant(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double GetDiscriminant()
        {
            return ((B * B) - (4 * A * C));
        }

        public double GetRoot1()
        {
            return -(B / (2 * A));
        }

        public void GetRoot2()
        {
            double nghiem1;
            double nghiem2;

            nghiem1 = (-B + Math.Sqrt(GetDiscriminant()) / (2 * A));
            nghiem2 = (-B - Math.Sqrt(GetDiscriminant()) / (2 * A));

            Console.WriteLine($"Phuong trinh co 2 nghiem: {nghiem1} va {nghiem2}");

        }

        public void Checked()
        {
            if (GetDiscriminant() < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (GetDiscriminant() == 0) 
            {
                Console.WriteLine($"Phuong trinh co 1 nghiem: {GetRoot1()}");
            }
            else
            {
                GetRoot2();
            }
        }
    }
}
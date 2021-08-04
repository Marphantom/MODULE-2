using System;

namespace phuongtrinhbac2
{
    public class QuadraticEquation
    {
        private double numberA, numberB, numberC;
        public QuadraticEquation(double numberA, double numberB, double numberC)
        {
            this.numberA = numberA;
            this.numberB = numberB;
            this.numberC = numberC;
        }

        public double GetDiscriminant()
        {
            return (numberB * numberB) - 4 * (numberA * numberC);
        }

        public double GetRoot1()
        {
            return (-numberB + Math.Sqrt(GetDiscriminant())) / (2 * numberA);
        }
        public double GetRoot2()
        {
            return (-numberB - Math.Sqrt(GetDiscriminant())) / (2 * numberA);
        }

        public double GetRoot3()
        {
            return -(numberB / (2 * numberA));
        }
    }
}
using System;

namespace tinhcannang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight:");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            float height = float.Parse(Console.ReadLine());

            double bmi = weight/(height*height);

            if(bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                 Console.WriteLine("Normal");
            }
            else if (bmi < 30)
            {
                 Console.WriteLine("Overweight");
            }
            else
            {
                 Console.WriteLine("Obese");
            }
        }
    }
}

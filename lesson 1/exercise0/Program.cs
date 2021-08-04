using System;

namespace exercise0
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 5;



            Console.WriteLine("Value before increase: {0}", value);



            IncreaseValue(value);



            Console.WriteLine("Value after increase: {0}", value);

           

            Console.ReadKey();

        }



        static void IncreaseValue(int value)

        {

            value++;

        }
    }
}

using System;

namespace findMin2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size:");
            int size = Int32.Parse(Console.ReadLine());
            int [] array = new int [size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10,20);
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            Console.WriteLine($"Min: {min}");
        }
    }
}

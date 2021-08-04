using System;

namespace findMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int [] array;

            do
            {
                Console.WriteLine("Enter a size: ");
                size = Int32.Parse(Console.ReadLine());
                if(size > 20)
                {
                    Console.WriteLine("Size should not exceed 20");
                }
            }
            while (size > 20);

            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element [{i}]: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "-");
            }

            int max = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"Max is: {max}");

        }
    }
}

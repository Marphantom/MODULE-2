using System;

namespace daonguocmang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int [] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("size does not exceed 20");
                }
            }
            while(size > 20);

            array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter element: ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array {i}: {array[i]}");
            }

            // int temp;
            // for(int i = 0; i < array.Length/2; i++)
            // {
            //     temp = array[i];
            //     array[i] = array[array.Length - 1 - i];
            //     array[array.Length - 1 - i] = temp;
            // }

            // for (int i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine($"Array change {i}: {array[i]}");
            // }

            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array change {i}: {array[i]}");
            }
        }
    }
}

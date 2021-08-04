using System;

namespace inputArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {0,1,2,3,4,5,6,7,8,9};
            int numberX;
            int index;

            Console.WriteLine("Enter number X:");
            numberX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter index:");
            index = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Array is:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Array.Resize(ref array, 11);
            for (int i = 10; index <= i; i--)
            {
                array[i] = array[i - 1];
                
            }
            array[index] = numberX;


            Console.WriteLine("New array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}

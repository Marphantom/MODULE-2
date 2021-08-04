using System;

namespace findMinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array = {5,10,15,3,-3,1,8};

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine($"min array: {findMin(array)}");

        }

        static int findMin(int [] arr)
        {
            int min = arr [0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}

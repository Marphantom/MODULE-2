using System;

namespace delValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int numberX;

            Console.WriteLine("Enter number:");
            numberX = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (numberX == array[i])
                {
                    int j = i + 1;
                    while (j < array.Length)
                    {
                        array[j - 1] = array[j];
                        j++;
                    }
                }
            }
            Array.Resize(ref array, array.Length -1);

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

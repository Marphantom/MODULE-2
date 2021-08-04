using System;

namespace findMax2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int cols;
            int[,] matrix;

            Console.WriteLine("Enter rows:");
            rows = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols:");
            cols = Int32.Parse(Console.ReadLine());

            matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("Enter element:");
                    matrix[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (max < matrix[i,j])
                    {
                        max = matrix[i,j];
                    }
                }
            }
            
            Console.WriteLine($"Max : {max}");
        }
    }
}

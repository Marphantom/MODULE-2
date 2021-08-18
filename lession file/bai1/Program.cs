using System;
using System.IO;
using System.Linq;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Data CodeGym\MODULE-2\lession file\bai1";
            string input = "InputData.txt";
            string output = "OutputData.txt";
            int [][] matrix;

            using(StreamReader sr = File.OpenText(Path.Combine(path,input)))
            {
                string line = sr.ReadLine();
                string [] array = line.Split(" ");
                int row = int.Parse(array[0]);
                int col = int.Parse(array[1]);
                matrix = new int [row][];
                int i = 0;
                while((line = sr.ReadLine()) != null)
                {
                    int [] arr = new int [col];
                    arr = line.Split(" ").Select(v => int.Parse(v)).ToArray();
                    matrix[i] = arr;
                    i++;
                }
            }

            for(int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }

            int total = 0;
            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    total += matrix[i][j];
                }
            }

            using(StreamWriter sw = File.AppendText(Path.Combine(path,output)))
            {
                sw.WriteLine($"Tong la: {total}");
            }
        }
    }
}

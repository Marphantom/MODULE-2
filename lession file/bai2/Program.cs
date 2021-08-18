using System;
using System.IO;
using System.Linq;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Data CodeGym\MODULE-2\lession file\bai2";
            string input = "data.txt";
            string output = "out.txt";
            // Console.Write("Enter row: ");
            // int row = int.Parse(Console.ReadLine());
            // Console.Write("Enter col: ");
            // int col = int.Parse(Console.ReadLine());
            // Console.Write("Enter min: ");
            // int min = int.Parse(Console.ReadLine());
            // Console.Write("Enter max: ");
            // int max = int.Parse(Console.ReadLine());
            // int[][] matrix = GenerateMatrix(row,col,min,max);
            // writeFile(row,col,path,input,matrix);
            int[][] matrix2 = readFile(path,input);
            writeFileOutput(path, output,matrix2);
        }

        public static int[][] GenerateMatrix(int row, int col, int min, int max)
        {
            Random rd = new Random();
            int [][] matrix = new int [row][];
            for(int i = 0; i < row; i++)
            {
                int [] arr = new int [col];
                for (int j = 0; j < col; j++)
                {
                    arr[j] = rd.Next(min,max);
                }
                matrix[i] = arr;
            }
            return matrix;
        }

        public static void writeFile(int row, int col, string path, string input, int[][] matrix)
        {
            using(StreamWriter sw = File.CreateText(Path.Combine(path,input)))
            {
                sw.WriteLine(row);
                sw.WriteLine(col);
                for(int i = 0; i < matrix.Length;i++)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        sw.Write(matrix[i][j] + " ");
                    }
                    sw.WriteLine();
                }
            }
        }

        public static int totalEven (int[][] matrix)
        {
            int total = 0;
            for(int i = 0; i < matrix.Length;i++)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        if(matrix[i][j] % 2 == 0)
                        {
                            total += matrix[i][j];
                        }
                    }
                }
                return total;
        }

        public static int boiCua5 (int[][] matrix)
        {
            int total = 0;
            for(int i = 0; i < matrix.Length;i++)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        if(matrix[i][j] % 5 == 0)
                        {
                            total += matrix[i][j];
                        }
                    }
                }
                return total;
        }

        public static int[][] readFile(string path, string input)
        {
             using (StreamReader sr = File.OpenText(Path.Combine(path, input)))
            {
                string line = sr.ReadLine();
                int row = int.Parse(line);
                line = sr.ReadLine();
                int column = int.Parse(line);
                int[][] matrix = new int[row][];
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    int[] arr = new int[column];
                    arr = line.Split(" ").Select(v => int.Parse(v)).ToArray();
                    matrix[i] = arr;
                    i++;
                }
                return matrix;
            }
        }

        public static void writeFileOutput(string path, string output, int[][] matrix)
        {
            using(StreamWriter sw = File.CreateText(Path.Combine(path,output)))
            {
                sw.WriteLine($"Tong la: {totalEven(matrix)}");
                sw.WriteLine($"Tong la boi cua 5 la: {boiCua5(matrix)}");
            }
        }        
    }
}

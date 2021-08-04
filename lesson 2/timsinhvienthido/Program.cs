using System;

namespace timsinhvienthido
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int [] array;

            do
            {
                Console.WriteLine("Enter size:");
                size = Int32.Parse(Console.ReadLine()); 
                if (size > 30)
                {
                    Console.WriteLine("Size should not exceed 30");
                }
            }
            while(size > 30);

            array = new int [size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter element:");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] >= 5 && array[i] <=10)
                {
                    Console.WriteLine($"Sinh vien dau co diem so {array[i]}");
                    count ++;
                }
            }
            Console.WriteLine($"So luong sinh vien dau: {count}");
        }
    }
}

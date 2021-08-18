using System;
using System.Collections;
using System.Collections.Generic;

namespace DaoNguocMangStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack = new Stack();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < array.Length; i++)
            {
                MyStack.Push(array[i]);
            }

            object[] array1 = MyStack.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

        }
    }
}

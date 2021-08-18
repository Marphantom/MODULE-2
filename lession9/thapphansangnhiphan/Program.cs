using System;
using System.Collections;

namespace thapphansangnhiphan
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack MyStack = new Stack();
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            while(number != 0)
            {
                MyStack.Push(number%2);
                number /= 2;
            }

            object [] array = MyStack.ToArray();

            foreach(int arr in array)
            {
                Console.Write(arr);
            }
        }
    }
}

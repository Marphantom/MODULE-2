using System;
using System.Collections;

namespace CheckPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter string: ");
            // var myString = Console.ReadLine();

            var myString = "Able was I ere I saw Elba";

            Queue MyQueue = new Queue();
            Stack MyStack = new Stack();

            string[] array = myString.Split();

            foreach(string arr in array)
            {
                MyQueue.Enqueue(arr);
                
            }

             foreach(string arr in array)
            {
                MyStack.Push(arr);
            }

            object[] arr1 = MyQueue.ToArray();
            object[] arr2 = MyStack.ToArray();

            foreach(string ar in arr1)
            {
                Console.Write(ar + " ");
            }

            foreach(string ar in arr2)
            {
                Console.Write(ar + " ");
            }

            // for(var i = 0; i < array.Length; i++)
            // {
            //     if(arr1[i] == arr2[i])
            //     {
            //         Console.WriteLine("la chuoi palindrome");
            //     }
            //     else
            //     {
            //         Console.WriteLine("khong phai la chuoi palindrome");
            //     }
            // }
        }
    }
}

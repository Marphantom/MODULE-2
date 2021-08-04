using System;

namespace findValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] students = {"Nguyen", "Huy", "Chinh", "long"};

            Console.WriteLine("Enter a name student:");
            string input_name = Console.ReadLine();

            for(int i = 0; i < students.Length; i++)
            {
                if(input_name == students[i])
                {
                    Console.WriteLine($"Ten sinh vien la: {students[i]}");
                    break;
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien");
                }
            }
            
        }
    }
}

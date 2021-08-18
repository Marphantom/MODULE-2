using System;

namespace ClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student(1,"Nguyen","Hue", 28);
            Student st2 = new Student();
            st2.ID = 2;
            st2.Name = "Huy";
            st2.Address = "Paris";
            st2.Age = 24;
            
            Console.WriteLine(st1.ToString());
            Console.WriteLine(st2.ToString());
        }
    }
}

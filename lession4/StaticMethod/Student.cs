using System;

namespace StaticMethod
{
    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";
        public Student(int r, string n)
        {
            this.rollno = r;
            this.name = n;
        }

        public static void Change()
        {
            college = "CODEGYM";
        }

        public void Display()
        {
            Console.WriteLine(rollno + " "+ name + " " + college);
        }
    }
}
using System;
using System.Collections;

namespace ThemXoaArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentlist = new ArrayList();

            studentlist.Add(new Student {Name = "Nguyen", Age = 20});
            studentlist.Add(new Student {Name = "Chinh", Age = 18});
            studentlist.Add(new Student {Name = "Huy", Age = 19});

            foreach(Student std in studentlist)
            {
                Console.WriteLine(std.Name, std.Age);
            }

            studentlist[2] = new Student {Name = "Long", Age = 18};

            foreach(Student std in studentlist)
            {
                Console.WriteLine(std.Name, std.Age);
            }

            studentlist.Add(new Student {Name = "Thu", Age = 18});
            studentlist.RemoveAt(1);

            foreach(Student std in studentlist)
            {
                Console.WriteLine(std.Name, std.Age);
            }
        }
    }
}

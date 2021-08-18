using System;

namespace ClassStudent
{
    public class Student
    {
        private int id;
        private string name;
        private string address;
        private int age;

        public Student()
        {
            
        }
        public Student(int id, string name, string address, int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value;}

        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Address: {address}, Age: {age}";
        }
    }
}
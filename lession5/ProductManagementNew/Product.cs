using System;
using System.Collections;
{
    
}
namespace ProductManagementNew
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int[] Rate = new int[0];

        public Product()
        {
            
        }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void ViewInfo()
        {
            Console.WriteLine($"Name: {Name}\t\t Description: {Description}\t\t Price: {Price}");
        }
    }
}
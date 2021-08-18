using System;
using System.Collections;

namespace ProductManagementNew
{
    public class Shop
    {
        public ArrayList ProductList = new ArrayList();

         public void AddProduct()
        {
            Console.WriteLine("Enter product name:");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate value:");
            int rate = int.Parse(Console.ReadLine());

            Product product = new Product(productName, description, price);
            Array.Resize(ref product.Rate, product.Rate.Length + 1);
            product.Rate[product.Rate.Length - 1] = rate;

            ProductList.Add(product);
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter product name: ");
            var name = Console.ReadLine();
            ProductList.Remove(name);
        }

        public void IterateProductList()
        {
            foreach (Product pdt in ProductList)
            {
                pdt.ViewInfo();
            }
        }

        // public void SearchProduct()
        // {
        //     Console.Write("Enter min price:");
        //     double min = double.Parse(Console.ReadLine());
        //     Console.Write("Enter max price:");
        //     double max = double.Parse(Console.ReadLine());

        //     foreach (var pdt in ProductList)
        //     {
        //         if (pdt.Price >= min && pdt.Price <= max)
        //         {
        //             pdt.ViewInfo();
        //         }
        //     }
        // }
    }
}
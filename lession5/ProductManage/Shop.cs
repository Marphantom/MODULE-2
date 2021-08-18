using System;

namespace ProductManage
{
    public class Shop
    {
        public Product[] ProductList = new Product[0];

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

            Array.Resize(ref ProductList, ProductList.Length + 1);
            ProductList[ProductList.Length - 1] = product;
        }

        public void IterateProductList ()
        {
            foreach(Product pdt in ProductList)
            {
                pdt.ViewInfo();
                double total = 0;
                foreach(int value in pdt.Rate)
                {
                    total += value;
                }
                Console.WriteLine($"Average point: {total/pdt.Rate.Length}");
            }
        }

        public void RemoveProduct()
        {
            Console.WriteLine("Enter product name:");
            string name = Console.ReadLine();
            int position = -1;
            for(int i = 0; i < ProductList.Length; i++)
            {
                if(ProductList[i].Name.ToLower() == name)
                {
                    position = i;
                    break;
                }
            }
            if(position == -1)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                for(int i = position; i < ProductList.Length - 1; i++)
                {
                    ProductList[i] = ProductList[i + 1];
                }
                Array.Resize(ref ProductList, ProductList.Length - 1);
                Console.WriteLine("Product has been removed successfully");
                IterateProductList();
            }
        }

        public void SearchProduct()
        {
            Console.Write("Enter min price:");
            double min = double.Parse(Console.ReadLine());
            Console.Write("Enter max price:");
            double max = double.Parse(Console.ReadLine());

            foreach(Product pdt in ProductList)
            {
                if(pdt.Price >= min && pdt.Price <= max)
                {
                    pdt.ViewInfo();
                }
            }
        }
    }
}
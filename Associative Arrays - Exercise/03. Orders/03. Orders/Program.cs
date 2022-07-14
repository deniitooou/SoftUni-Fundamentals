using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string[] tokens = Console.ReadLine().Split();

            while (tokens[0] != "buy")
            {
                string currName = tokens[0];
                decimal currPrice = Convert.ToDecimal(tokens[1]);
                int currQty = int.Parse(tokens[2]);

                if (!products.Any(product => product.Name == currName))
                {
                    Product newProduct = new Product(currName);
                    products.Add(newProduct);
                }
                Product currProduct = products.Find(product => product.Name == currName);
                currProduct.Price = currPrice;
                currProduct.Quantity += currQty;

                tokens = Console.ReadLine().Split();
            }

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }

    class Product
    {
        public Product(string name)
        {
            Name = name;
            Price = 0.00m;
            Quantity = 0;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get { return this.Price * this.Quantity; } }

        public override string ToString()
        {
            return $"{this.Name} -> {this.TotalPrice:f2}";
        }
    }
}


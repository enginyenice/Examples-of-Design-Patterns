using System;
using PrototypeDesignPattern.Models;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.IdInfo = new IdInfo(1000);
            p1.Name = "Product One";
            p1.Price = 5.55;
            p1.CreatedAt = DateTime.Now;
            p1.Description = "Product One Description";

            System.Console.WriteLine($"P1:\t{p1.ToString()}");

            Product p2 = (Product)p1.ShallowCopy();
            System.Console.WriteLine($"P2:\t{p2.ToString()}");

            Product p3 = (Product)p1.DeepCopy();
            System.Console.WriteLine($"P3:\t{p3.ToString()}");
        }
    }
}

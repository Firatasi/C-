using System;
using System.Net.Http.Headers;

namespace Project4.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            foreach (var product in productManager.Products.GetAll() {
                Console.WriteLine(product.Name);
            }

    }
}
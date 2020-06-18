using System;
using App.Application.Services;
using App.Domain.Entities;
using App.Infrastructure.Data;

namespace App.UI
{
    internal class Program
    {
        private static void Main()
        {
            var productService = new ProductService(new ProductRepository());

            var product = new Product
            {
                Id = 21,
                Description = "Product description"
            };

            productService.RegisterNewProduct(product);

            Console.ReadKey();
        }
    }
}

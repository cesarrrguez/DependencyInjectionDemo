using System;
using App.Domain.Entities;
using App.Domain.Interfaces.Services;
using App.Infra.Bootstrap;

namespace App.UI
{
    internal class Program
    {
        private static void Main()
        {
            var productService = IoC.Container.GetInstance<IProductService>();

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

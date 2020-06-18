using System;
using App.Domain.Entities;
using App.Domain.Interfaces.Repositories;

namespace App.Infra.Data
{
    public class ProductRepository : IProductRepository
    {
        public void Add(Product product)
        {
            Console.WriteLine($"Adding product {product.Id} - {product.Description} into db");
        }
    }
}
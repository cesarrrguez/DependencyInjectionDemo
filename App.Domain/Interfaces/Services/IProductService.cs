using App.Domain.Entities;

namespace App.Domain.Interfaces.Services
{
    public interface IProductService
    {
        void RegisterNewProduct(Product product);
    }
}

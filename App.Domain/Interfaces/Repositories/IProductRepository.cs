using App.Domain.Entities;

namespace App.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
    }
}

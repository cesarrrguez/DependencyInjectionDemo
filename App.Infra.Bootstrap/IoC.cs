using App.Application.Services;
using App.Domain.Interfaces.Repositories;
using App.Domain.Interfaces.Services;
using App.Infra.Data;
using SimpleInjector;

namespace App.Infra.Bootstrap
{
    public class IoC
    {
        public static Container Container;

        static IoC()
        {
            Container = new Container();

            Container.Register<IProductService, ProductService>();

            Container.Register<IProductRepository, ProductRepository>();
        }
    }
}

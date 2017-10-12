using webShopSanaTest.Web.Repositories;

namespace webShopSanaTest.Web
{
    public interface IUnitOfWork
    {
        IProductRepository products { get; }
        ICategoryRepository categories { get;  }
        void Complete();

    }
}
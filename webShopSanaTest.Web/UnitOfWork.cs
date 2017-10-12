using webShopSanaTest.DataModel;
using webShopSanaTest.Web.Repositories;

namespace webShopSanaTest.Web
{
    public class UnitOfWork : IUnitOfWork
    {
        private webshopdsEntities _context;

        public IProductRepository products { get; private set; }

        public ICategoryRepository categories { get; private set; }

        public UnitOfWork(webshopdsEntities context)
        {
            _context = context;
            products = new ProductRepository(context);
            categories = new CategoryRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
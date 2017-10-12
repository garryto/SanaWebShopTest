using System.Collections.Generic;
using System.Linq;
using webShopSanaTest.DataModel;

namespace webShopSanaTest.Web.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private webshopdsEntities _context;
        public CategoryRepository(webshopdsEntities context)
        {
            _context = context;
        }

        public List<Category> GetAll()
        {
           
            var query = from b in _context.Category
                        orderby b.Name
                        select b;
            return query.ToList();

        }

    }
}
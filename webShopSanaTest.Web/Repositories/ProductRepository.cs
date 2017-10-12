using System.Collections.Generic;
using System.Linq;
using webShopSanaTest.DataModel;

namespace webShopSanaTest.Web.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private webshopdsEntities _context;
        public ProductRepository(webshopdsEntities context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
           
            var query = from b in _context.Product
                        orderby b.Title
                        select b;
            return query.ToList();
        }

        public void InsertProduct(Product product)
        {
           
            foreach (Category inputCatg in product.Category.ToList())
            {


                Category catg = _context.Category.FirstOrDefault(s => s.Id == inputCatg.Id);
                product.Category.Remove(inputCatg);
                product.Category.Add(catg);

            }
            _context.Product.Add(product);

        }
    }
}
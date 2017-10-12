using System.Collections.Generic;
using webShopSanaTest.DataModel;

namespace webShopSanaTest.Web.Repositories
{
    public  interface IProductRepository
    {
        List<Product> GetAll();
        
        void InsertProduct(Product product);
        
    }
}
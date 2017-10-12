using System.Collections.Generic;
using webShopSanaTest.DataModel;

namespace webShopSanaTest.Web.ViewModels
{
    public class ProductViewModel
    {
        public Product product;
        public IEnumerable<Category> Categories { get; set; }
    }
}
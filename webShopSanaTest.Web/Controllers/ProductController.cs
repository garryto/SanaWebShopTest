using System.Collections.Generic;
using System.Web.Mvc;
using webShopSanaTest.DataModel;
using webShopSanaTest.Web.ViewModels;

namespace webShopSanaTest.Web.Controllers
{
    public class ProductController : Controller
    {
        

        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        
        }



        // GET: Product
        public ActionResult Index()
        {
            
            var productList = _unitOfWork.products.GetAll();
            return View(productList);
        }


        // GET: Product/Create
        public ActionResult Create()
        {

            var viewModel = new ProductViewModel
            {

                product = new Product(),
                Categories = _unitOfWork.categories.GetAll()
            };
            return View(viewModel);

        }


       // POST: Product/Create
       [HttpPost]
        public ActionResult Create(Product product, List<Category> objCategory)        
        {

           


            int numCategories = objCategory.Count;
            int i = 0;

            while (i < numCategories)
            {
                if (objCategory[i].checkboxAnswer == false)
                {

                    objCategory.RemoveAt(i);
                    i = 0;
                    numCategories = objCategory.Count;
                } else
                {
                    i++;
                }
            } 

            product.Category = objCategory;


            _unitOfWork.products.InsertProduct(product);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }
        


    }
}
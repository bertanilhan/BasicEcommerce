using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicECommerce.Business.Abstract;
using BasicECommerce.MvcWebUI.Models;

namespace BasicECommerce.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View(new ProductListViewModel
            {
                Products = _productService.GetAll()
            });
        }
        public ActionResult List(int? categoryId)
        {
            
            if (categoryId.HasValue)
            {
                
                return View("Index",new ProductListViewModel
                {
                    Products = _productService.GetByCategoryId(categoryId.Value)
                });
            }

            return RedirectToAction("Index");

        }

        public ActionResult Detail(int id)
        {
            return View(new ProductViewModel
            {
                Product = _productService.GetById(id)
            });
        }
    }
}
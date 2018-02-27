using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicECommerce.Business.Abstract;
using BasicECommerce.MvcWebUI.Models;

namespace BasicECommerce.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ActionResult Index(int categoryId=0)
        {
            ViewBag.CurrentCategoyId = categoryId;
            return View(new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            });
        }
        
    }
}
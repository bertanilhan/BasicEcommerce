using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicECommerce.Business.Abstract;
using BasicECommerce.Entities.Concrete;
using BasicECommerce.MvcWebUI.Models;

namespace BasicECommerce.MvcWebUI.Controllers
{
    public class NavbarController : Controller
    {
        private ICategoryService _categoryService;

        public NavbarController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public PartialViewResult Index(int categoryId=0)
        {
            ViewBag.CurrentCategoryId = categoryId;

            return PartialView(new NavbarViewModel
            {
                Categories = _categoryService.GetAll()
            });
        }
    }
}
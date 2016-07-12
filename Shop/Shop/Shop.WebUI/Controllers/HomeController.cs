using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Entities.Product;
using Shop.DataSource.Entities.User;
using Shop.DataSource.Repositories;

namespace Shop.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<Category> _categoryRepository; 

        public HomeController(
            IRepository<User> userRepository, 
            IRepository<Product> productRepository, 
            IRepository<Category> categoryRepository)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ActionResult Index()
        {
            var categories = _categoryRepository.GetAll().ToList();
            var defaultCategory = categories.FirstOrDefault();
            var products = _productRepository.GetAll(p => p.CategoryId == defaultCategory.Id).ToList();

            ViewBag.Categories = categories;
            ViewBag.DefaultCategory = defaultCategory;
            ViewBag.Products = products;
            
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}

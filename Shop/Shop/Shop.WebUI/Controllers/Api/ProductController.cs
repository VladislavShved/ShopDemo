using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Entities.Product;
using Shop.DataSource.Repositories;

namespace Shop.WebUI.Controllers.Api
{
    public class ProductController : ApiController
    {
        private readonly IRepository<Product> _productRepository;

        public ProductController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public List<Product> GetProductsByCategory([FromUri]Guid categoryId)
        {
            return _productRepository.GetAll(p => p.CategoryId == categoryId).ToList();
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _productRepository.GetAll().ToList();
        }
    }
}

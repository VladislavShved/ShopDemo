using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shop.DataSource.Entities.Category;
using Shop.DataSource.Repositories;

namespace Shop.WebUI.Controllers.Api
{
    public class CategoryController : ApiController
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryController(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetAll().ToList();
        }
    }
}

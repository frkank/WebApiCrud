using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCrud.Bussiness.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeContreller : ControllerBase
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeContreller(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        [HttpGet]
        public List<Product> GetList()
        {
            return _productService.GetAll();
        }
    }
}

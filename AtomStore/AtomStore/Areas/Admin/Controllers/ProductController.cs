using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomStore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AtomStore.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        IProductCategoryService _productCategoryService;
        IProductService _productService;
        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region AJAX API
        [HttpGet]
        public IActionResult GetAll()
        {
            var model = _productService.GetAll();
            return new OkObjectResult(model);  
        }
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);  
        }

        [HttpGet]
        public IActionResult GetAllPaging(int? categoryId,string keyWord, int page,int pageSize)
        {
            var model = _productService.GetAllPaging(categoryId, keyWord, page, pageSize);
            return new OkObjectResult(model);
        }
        #endregion
    }
}
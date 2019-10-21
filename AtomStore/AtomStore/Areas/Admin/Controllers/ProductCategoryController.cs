using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomStore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AtomStore.Areas.Admin.Controllers
{
    public class ProductCategoryController : BaseController
    {
        IProductCategoryService _productCategoryService;
        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region Get Data API
        public IActionResult GetAll()
        {
            var model = _productCategoryService.GetAll();
            return new OkObjectResult(model);
        }
        #endregion
    }
}
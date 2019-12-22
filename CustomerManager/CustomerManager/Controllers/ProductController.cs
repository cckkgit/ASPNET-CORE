using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Services;
using CustomerManager.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManager.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var listProducts = _service.GetAllProducts();
            return View(listProducts);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult SaveNew(ProductViewModel product)
        {
            _service.AddProduct(product);
            return Redirect("Index");
        }
        public IActionResult View(Guid id)
        {
            var product = _service.GetProduct(id);
            return View(product);
        }

        public IActionResult Edit(Guid id)
        {
            var product = _service.EditProduct(id);
            return View(product);
        }
    }
}
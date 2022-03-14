using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeyazEsyaSepeti.Models;
using BeyazEsyaSepeti.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BeyazEsyaSepeti.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IUserService _userService;

        public ProductController(IProductService productService, IUserService userService)
        {
            _productService = productService;
            _userService = userService;
        }


        public IActionResult Index(string id)
        {
            var userModel = _userService.GetUserById(id);
            var products = _productService.GetAllProducts().OrderBy(x=>x.Name).Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();

            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;

            return View(container);
        }

        [HttpGet]
        public IActionResult Buzdolabı(string id)
        {
            var userModel = _userService.GetUserById(id);
            var products = _productService.GetProductsByCategory("buzdolabı").Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();

            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;

            return View(container);
        }

        [HttpGet]
        public IActionResult CamasırMakinesi(string id)
        {
            var userModel = _userService.GetUserById(id);
            var products = _productService.GetProductsByCategory("CamasırMakinesi").Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();
            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;
            return View(container);
        }

        [HttpGet]
        public IActionResult BulasikMakinesi(string id)
        {
            var userModel = _userService.GetUserById(id);
            var products = _productService.GetProductsByCategory("BulasikMakinesi").Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();
            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;
            return View(container);
        }

        [HttpGet]
        public IActionResult Firin(string id)
        {
            var userModel = _userService.GetUserById(id);
            var products = _productService.GetProductsByCategory("firin").Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();
            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;
            return View(container);
        }

    }

}
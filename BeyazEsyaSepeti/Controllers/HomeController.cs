using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeyazEsyaSepeti.Models;
using BeyazEsyaSepeti.Service;
using Microsoft.AspNetCore.Hosting;
using BeyazEsyaSepeti.Service.Interface;

namespace BeyazEsyaSepeti.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IProductService productService, IHostingEnvironment hostingEnvironment)
        {
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(User model)
        {
            return View(model);
        }

        public IActionResult Index2(User userModel)
        {

            var products = _productService.GetAllProducts().OrderBy(x=>x.Name).Select(k => new Product { Id = k.Id, Name = k.Name, Price = k.Price }).ToList();

            UserProductContainer container = new UserProductContainer();
            container.user = userModel;
            container.productList = products;

            return View(container);
        }
    }

       
    }


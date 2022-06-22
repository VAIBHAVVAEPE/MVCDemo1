using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult GetAllProduct()
        {
            List<Product> ProductList = new()
            {
                new Product{Id=1,Name="Laptop",Company="DEl",Price=35222},
                new Product{Id=2,Name="Laptop",Company="DEl",Price=35222},
                new Product{Id=3,Name="Laptop",Company="DEl",Price=35222},
                new Product{Id=4,Name="Laptop",Company="DEl",Price=35222},



            };
            ViewBag.ProductList = ProductList;
            return View();
        }
    }
}

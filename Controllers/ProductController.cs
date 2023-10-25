using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProdcutList()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Mouse",Price=1000},
                new Product { Id = 2,Name="Pen",Price=100},
                new Product { Id = 3,Name="Pendrive",Price = 400}, 
                new Product { Id = 4,Name="Wire",Price=220},
                new Product { Id = 5,Name="Bottle",Price=939},
            };
            ViewBag.List=products;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebAppDay2.Models;

namespace WebAppDay2.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();
        private static int idCounter = 1;
        public IActionResult Index()
        {
            return View(products);
        }
        public string Details()
        {
            return "This is the detail action method......";
        }
        [HttpGet("/product/create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = idCounter++;
            products.Add(product);
            return Redirect("Index");
        }
        public string Delete()
        {
            return "This is the delete action method...";
        }
    }

    }












 
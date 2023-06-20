using Microsoft.AspNetCore.Mvc;

namespace MyWebApp2.wwwroot
{
    public class Products : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}

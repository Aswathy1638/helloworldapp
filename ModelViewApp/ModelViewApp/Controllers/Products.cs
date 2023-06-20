using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;

namespace ModelViewApp.Controllers;

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
}

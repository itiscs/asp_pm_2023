using Microsoft.AspNetCore.Mvc;
using SessionApp.Models;
using System.Diagnostics;

namespace SessionApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;            
        }

        public IActionResult Index()
        {
            if(Request.Cookies.ContainsKey("name"))
            {
                var cook = Request.Cookies["name"];
                ViewData["name"] = Request.Cookies["name"]?.ToString();
            }

            if(HttpContext.Session.Keys.Contains("cart"))
            {
                ViewData["cart"] = HttpContext.Session.GetString("cart");
            }
            return View();
        }

        public IActionResult Privacy(string? name)
        {
            if(name != null) 
            {   
                Response.Cookies.Append("name", name);                
            }
            return View();
        }

        public IActionResult AddToCart(int? id)
        {
            if (id != null)
            {
                ViewData["item"] = id.ToString();
                if(!HttpContext.Session.Keys.Contains("cart")) 
                {
                    HttpContext.Session.SetString("cart", "");
                }

                var str = HttpContext.Session.GetString("cart");
                HttpContext.Session.SetString("cart",str + $"{id} ");                
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Shortly.Client.Data.Models;

namespace Shortly.Client.Controllers
{
    public class UrlController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ShortenedUrl = "This is just a shot url";
            ViewBag.AllUrls = new List<string>() { "url1", "url2", "url3" };
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MvcBooks.Models;

namespace MvcBooks.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            DB db = new DB();
            ViewBag.Cats = db.cats;
            return View();
        }
    }
}

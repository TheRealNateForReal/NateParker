using Microsoft.AspNetCore.Mvc;

namespace NateParker.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

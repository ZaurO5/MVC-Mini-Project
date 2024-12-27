using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Page404()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
    }
}

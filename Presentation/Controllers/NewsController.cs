using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
        public IActionResult SingleNews()
        {
            return View();
        }
    }
}

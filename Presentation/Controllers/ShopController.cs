using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult SingleProduct()
        {
            return View();
        }
    }
}

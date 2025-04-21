using Microsoft.AspNetCore.Mvc;

namespace KabogluTeknik.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

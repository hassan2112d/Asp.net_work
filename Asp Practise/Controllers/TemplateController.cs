using Microsoft.AspNetCore.Mvc;

namespace Asp_Practise.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}

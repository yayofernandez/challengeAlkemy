using Microsoft.AspNetCore.Mvc;

namespace Universidad.Controllers
{
    public class SectionsController : Controller
    {
        public SectionsController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
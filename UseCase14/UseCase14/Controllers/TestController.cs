using Microsoft.AspNetCore.Mvc;

namespace UseCase14.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Lab26George.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}

using Lab26George.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lab26George.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lab26GeorgeContext _context;

        public HomeController(Lab26GeorgeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Player.Where(p => p.PlayerID == 1);

            return View();
        }
    }
}

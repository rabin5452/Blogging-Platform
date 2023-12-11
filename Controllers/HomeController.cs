using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Webapp.Data;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebappDbContext _db;

        public HomeController(ILogger<HomeController> logger,WebappDbContext db)
        {
            _logger = logger;
            _db=db;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            List<Post> postobj=_db.posts.ToList();
            return View(postobj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
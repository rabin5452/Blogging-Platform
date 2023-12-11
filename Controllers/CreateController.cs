using Microsoft.AspNetCore.Mvc;
using Webapp.Data;
using Webapp.Models;

namespace Webapp.Controllers
{
    public class CreateController : Controller
    {
        private readonly WebappDbContext _db;
        public CreateController(WebappDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Post post)
        {
            _db.posts.Add(post);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

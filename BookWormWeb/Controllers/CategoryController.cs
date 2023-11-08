using BookWormWeb.Data;
using BookWormWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookWormWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Can be used "var" instead of List<Category>.
            List<Category> objCategoryList = _db.Categories.ToList();
            return View();
        }
    }
}

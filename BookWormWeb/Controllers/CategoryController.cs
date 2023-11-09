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
            //Can be used "var" instead of List<Category>. More readable with List.
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //here create function the Category obj created in the model as a return type of the over Create function
        public IActionResult Create(Category obj)
        {
            //Checkss with the validation from Model e.g. : Range, Required, MaxLength etc.. 
            //if not valid return 
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
            //return RedirectToAction("Index", "Category");
        }
    }
}

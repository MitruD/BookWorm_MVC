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

        //If no tags defined, then by default it's a GET action.
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]  //POST action
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
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //Several ways to retrieve a Category
            //1. Find(looks for Primary key)
            Category? categoryFromDb = _db.Categories.Find(id);
            //Category categoryFromDb = _db.Categories.FirstOrDefault(c => c.Id == id);FirstOrDefault works also with other parameters besides PK
            //Category categoryFromDb = _db.Categories.Where(c => c.Id == id).FirstOrDefault(); same as FirstOrDefault
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
        }
    }
}

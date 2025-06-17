using Microsoft.AspNetCore.Mvc;
using MVC_Lecture1.Data;
using MVC_Lecture1.Models;

namespace MVC_Lecture1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }

        public ViewResult Details(int id)
        {
            Console.WriteLine(id);
            var category = context.Categories.Find(id);
            return View(category);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Lecture1.Models;

namespace MVC_Lecture1.Controllers
{
    public class EmployeeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index","Raheeq");
        }
    }
}

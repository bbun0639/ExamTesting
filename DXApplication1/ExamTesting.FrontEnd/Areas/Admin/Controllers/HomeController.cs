using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting_FrontEnd.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ExamTestingDbContext _db;

        public HomeController(ExamTestingDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View();
        }

    }
}

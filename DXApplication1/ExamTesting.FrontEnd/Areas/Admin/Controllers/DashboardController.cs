using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting_FrontEnd.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    
    public class DashboardController : Controller
    {
        private readonly ExamTestingDbContext _db;

        public DashboardController(ExamTestingDbContext db)
        {
            _db = db;
        }
               
        public IActionResult Index()
        {
            return View();
        }

    }
}

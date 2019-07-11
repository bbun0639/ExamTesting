using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting.FrontEnd.Areas.Admin.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ExamTesting.DAL;

namespace ExamTesting.FrontEnd.Areas.Users.Controllers
{
    [Area("User")]
    public class ExamController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public ExamController(ExamTestingDbContext db)
        {
            _db = db;
        }
        public IActionResult Details(Guid id)
        {
            var _exams = _db.Exams.First(a => a.ExamCodeId == id);
            return View(_exams);
        }

        public IActionResult Testing(Guid id)
        {
            var _exams = _db.Exams.First(a => a.ExamCodeId == id);
            return View(_exams);
        }

        //[HttpGet]
        //public object GetChoice(DataSourceLoadOptions loadOptions)
        //{
        //    return DataSourceLoader.Load(_db.Choices.Where(u => u.QuestionId == ), loadOptions);
        //}


    }
}
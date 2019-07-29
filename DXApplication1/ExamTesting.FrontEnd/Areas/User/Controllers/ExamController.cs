
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
            var _exams = _db.UserExams.First(a => a.ExamId == id);
            return View(_exams);
        }

        public IActionResult Testing(Guid id)
        {
            var _exams = _db.UserExams.First(a => a.ExamId == id);
            return View(_exams);
        }


        [HttpGet]
        public object GetQuestion(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.QuestionExams.Where(u => u.ExamId == id), loadOptions);
        }

        [HttpGet]
        public object GetChoice(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.Choices.Where(u => u.QuestionId == id), loadOptions);
        }

    }
}
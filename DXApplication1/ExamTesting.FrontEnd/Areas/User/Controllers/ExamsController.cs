using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamTesting.FrontEnd.Areas.User.Controllers
{
    [Area("User")]
    public class ExamsController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public ExamsController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Exams, loadOptions);
        }

        [HttpGet]
        public object GetSubjects(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Subjects, loadOptions);
        }


        public async Task<IActionResult> Index()
        {
            List<ExamTesting.Models.Exam> examsList;
            examsList = await _db.Exams.ToListAsync();
            return View(examsList);
        }

    }
}
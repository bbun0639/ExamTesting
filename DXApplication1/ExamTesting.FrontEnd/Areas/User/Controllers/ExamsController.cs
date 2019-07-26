using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using ExamTesting.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ExamTesting.FrontEnd.Areas.User.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]

    public class ExamsController : Controller
    {
        protected Guid CurrentUserId => Guid.Parse(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);
        

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
        public object GetUserExam(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.UserExams.Where(u => u.UserId == CurrentUserId), loadOptions);
        }

        [HttpGet]
        public object GetSubjects(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Subjects, loadOptions);
        }


        public IActionResult Index()
        {
            //List<ExamTesting.Models.Exam> examsList;
            //examsList = await _db.Exams.ToListAsync();
            //return View(examsList);

            return View();
        }

        public IActionResult EnrollExams()
        {
            return View();
        }


        
        [HttpPost]
        public IActionResult AddExams(string examsString)
        {
            var _user = _db.Users.First(a => a.UserId == CurrentUserId);

            List<Exam> examList = JsonConvert.DeserializeObject<List<Exam>>(examsString);

            _user.AddExams(examList);

            _db.SaveChanges();


            return RedirectToAction("Index", "Exams");
        }


    }
}
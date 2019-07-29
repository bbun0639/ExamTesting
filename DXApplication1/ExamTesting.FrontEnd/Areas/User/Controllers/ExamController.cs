
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authorization;

namespace ExamTesting.FrontEnd.Areas.Users.Controllers
{
    [Area("User")]
    //[Authorize(Roles = "User")]
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
        public object GetExamQuestion(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.QuestionExams.Where(u => u.ExamId == id), loadOptions);
        }

        [HttpGet]
        public object GetChoice(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.Choices.Where(u => u.QuestionId == id), loadOptions);
        }





        public IActionResult QuestionAnswer(Guid id)
        {
            var _exams = _db.QuestionExams.First(a => a.QuestionId == id);
            return View(_exams);
        }


        [HttpGet]
        public IActionResult Test(Guid id)
        {
            var _UserExams = _db.UserExams.First(a => a.ExamId == id);
            _UserExams.StartExam();

            _db.SaveChanges();
            return View(_UserExams);
        }

        [HttpPost, ActionName("Test")]
        public IActionResult TestPost(Guid id, Guid questionAnswer)
        {

            var _questionAnswer = _db.UserExamQuestions.First(a => a.UserExam.ExamId == id);
            _questionAnswer.SelectChoiceId = questionAnswer;

            _db.SaveChanges();

            return RedirectToAction("Test");
        }
    }
}
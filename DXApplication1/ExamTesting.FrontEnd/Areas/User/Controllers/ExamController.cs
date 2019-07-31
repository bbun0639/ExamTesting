
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace ExamTesting.FrontEnd.Areas.Users.Controllers
{
    [Area("User")]
    [Authorize(Roles = "User")]
    public class ExamController : Controller
    {
        private readonly ExamTestingDbContext _db;

        protected Guid CurrentUserId => Guid.Parse(this.User.FindFirst(ClaimTypes.NameIdentifier).Value);

        public ExamController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var _exams = _db.UserExams.First(a => a.ExamId == id);
            return View(_exams);
        }

        //[HttpGet]
        //public IActionResult Testing(Guid id)
        //{
        //    var _exams = _db.UserExams.First(a => a.ExamId == id);
        //    return View(_exams);
        //}


        [HttpGet]
        public object GetExamQuestion(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.UserExamQuestions.Where(u => u.UserExam.ExamId == id), loadOptions);
        }

        [HttpGet]
        public object GetChoice(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.Choices.Where(u => u.QuestionId == id), loadOptions);
        }


        public IActionResult QuestionAnswer(Guid id)
        {
            var _exams = _db.UserExamQuestions.Where(a => a.UserExamQuestionId == id).ToList();

            foreach (var _question in _exams)
            {
                _exams.ForEach(e =>
                {
                    if (e.QuestionId == _question.QuestionId)
                    {
                        _db.SaveChanges();
                    }
                });
                return View(_question);
            }
            return View(_exams);
        }


        [HttpGet]
        public IActionResult Start(Guid id)
        {
            var _UserExams = _db.UserExams.First(a => a.ExamId == id);
            _UserExams.StartExam();

            _db.SaveChanges();
            //return View(_UserExams);
            return RedirectToAction("Test", new { id = id });
        }


        [HttpGet]
        public IActionResult Test(Guid id)
        {
            var _exams = _db.UserExamQuestions.Where(a => a.UserExam.ExamId == id).ToList();
            foreach (var _userExam in _exams)
            {
                _exams.ForEach(u =>
                {
                    if (u.UserExamQuestionId == _userExam.UserExamQuestionId)
                    {
                        _userExam.UserExam.UpdateScore();
                        _db.SaveChanges();

                    }

                });
                return View(_userExam);
            }

            return View(_exams);
        }


        [HttpPost, ActionName("Test")]
        public IActionResult TestPost(Guid id, Guid questionAnswer, Guid QuestionId)
        {

            var _questionAnswer = _db.UserExamQuestions.Where(a => a.UserExam.ExamId == id).ToList();

            foreach (var _questAns in _questionAnswer)
            {
                if (_questAns.QuestionId == QuestionId)
                {
                    _questAns.SelectChoiceId = questionAnswer;
                    _questAns.IsComplete = true;
                }

                _questAns.VerifyAnswer();

            }

            _db.SaveChanges();

            return RedirectToAction("Result", new { id = id });
        }


        [HttpGet]
        public IActionResult Result(Guid id)
        {
            var _result = _db.UserExams.First(a => a.ExamId == id);

            if(_result.TotalEarnScore >= ())

            return View(_result);
        }
    }
}
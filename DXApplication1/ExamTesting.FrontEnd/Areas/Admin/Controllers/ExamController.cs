using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using ExamTesting.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamTesting.FrontEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    [Route("Admin/Exam/{id}")]
    public class ExamController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public ExamController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [Route("")]
        [Route("Details")]
        public IActionResult Index(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));

        [Route("AssignQuestions")]
        public IActionResult AssignQuestions(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));

        [Route("Questions")]
        public IActionResult Questions(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));

        [Route("TestedBy")]
        public IActionResult TestedBy(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));

               
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

        [HttpGet]
        public object GetChoices(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Choices, loadOptions);
        }



        //[Route("AddQuestions")]
        [HttpPost]
        public IActionResult AddQuestions(Guid id, string questionsString)
        {
            var _exam = _db.Exams.First(a => a.ExamCodeId == id);
            List<Question> questionsList = JsonConvert.DeserializeObject<List<Question>>(questionsString);
            _exam.AddQuestionns(questionsList);

            _db.SaveChanges();


            return RedirectToAction("Index", "Exam", new { id = id });
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using ExamTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamTesting.FrontEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExamController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public ExamController(ExamTestingDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));
        public IActionResult AssignQuestions(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));
        public IActionResult Questions(Guid id) => View(_db.Exams.First(a => a.ExamCodeId == id));




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

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newExam = new Exam();
            newExam.ExamCodeId = new Guid();
            newExam.ExamCodeId = Guid.NewGuid();

            JsonConvert.PopulateObject(values, newExam);

            _db.Exams.Add(newExam);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var _exam = _db.Exams.First(a => a.ExamCodeId == key);

            JsonConvert.PopulateObject(values, _exam);

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var _exam = _db.Exams.First(a => a.ExamCodeId == key);

            _db.Exams.Remove(_exam);
            _db.SaveChanges();
        }





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
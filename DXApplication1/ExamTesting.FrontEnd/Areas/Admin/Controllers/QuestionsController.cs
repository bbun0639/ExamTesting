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
    [Authorize(Roles="Admin")]
    public class QuestionsController : Controller
    {

        private readonly ExamTestingDbContext _db;

        public QuestionsController(ExamTestingDbContext db)
        {
            _db = db;

        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Questions, loadOptions);
        }

        [HttpGet]
        public object GetTopicDropdown(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Topics, loadOptions);
        }

        [HttpGet]
        public object GetExam(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.QuestionExams.Where(m => m.ExamId == id), loadOptions);
        }

        [HttpDelete]
        public void DeleteExam(Guid key)
        {
            var question = _db.QuestionExams.First(a => a.QuestionId == key);

            _db.QuestionExams.Remove(question);
            _db.SaveChanges();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newQuestion = new Question();
            newQuestion.QuestionId = new Guid();
            //newQuestion.QuestionId = Guid.NewGuid();
            JsonConvert.PopulateObject(values, newQuestion);

            _db.Questions.Add(newQuestion);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var _question = _db.Questions.First(a => a.QuestionId == key);

            JsonConvert.PopulateObject(values, _question);

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var _question = _db.Questions.First(a => a.QuestionId == key);

            _db.Questions.Remove(_question);
            _db.SaveChanges();
        }

        public IActionResult Index()
        {
            
            return View();
        }        


    }
}

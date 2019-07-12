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
    public class QuestionController : Controller
    {
        private readonly ExamTestingDbContext _db;

        public QuestionController(ExamTestingDbContext db)
        {
            _db = db;

        }

        public IActionResult Index(Guid id)
        {
            var _question = _db.Questions.First(a => a.QuestionId == id);

            return View(_question);
        }


        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions, Guid id)
        {
            return DataSourceLoader.Load(_db.Choices.Where(g => g.QuestionId == id), loadOptions);
        }

        [HttpGet]
        public object GetTopicDropdown(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Topics, loadOptions);
        }


        [HttpPost]
        public IActionResult Post(string values)
        {
            var newChoice = new Choice();
            newChoice.ChoiceId = new Guid();

            JsonConvert.PopulateObject(values, newChoice);

            _db.Choices.Add(newChoice);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var _choice = _db.Choices.First(a => a.ChoiceId == key);

            JsonConvert.PopulateObject(values, _choice);

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var _choice = _db.Choices.First(a => a.ChoiceId == key);

            _db.Choices.Remove(_choice);
            _db.SaveChanges();
        }



    }
}
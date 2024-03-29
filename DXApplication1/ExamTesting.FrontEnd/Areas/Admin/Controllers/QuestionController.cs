﻿using System;
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


    //[Route("Admin/Question/{id}")]
    public class QuestionController : Controller
    {
        private readonly ExamTestingDbContext _db;

        public QuestionController(ExamTestingDbContext db)
        {
            _db = db;

        }

        //[Route("Details")]
        public IActionResult Index(Guid id)
        {
            var _question = _db.Questions.First(a => a.QuestionId == id);

            return View(_question);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult IndexPost(Guid id, Question question)
        {
            var _question = _db.Questions.First(a => a.QuestionId == id);
            _question.QuestionStr = question.QuestionStr;
            _question.Hint = question.Hint;
            _question.QuestionLevel = question.QuestionLevel;
            _question.QuestionType = question.QuestionType;
            _question.TopicId = question.TopicId;
            _question.QuestionPoint = question.QuestionPoint;

            _db.SaveChanges();
            return RedirectToAction("Index", "Questions");
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
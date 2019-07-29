using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExamTesting.FrontEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    [Route("Admin/Subject/{id}")]
    public class SubjectController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public SubjectController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Subjects, loadOptions);
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newSubject = new ExamTesting.Models.Subject();
            newSubject.SubjectId = new Guid();

            JsonConvert.PopulateObject(values, newSubject);

            _db.Subjects.Add(newSubject);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var _subject = _db.Subjects.First(a => a.SubjectId == key);

            JsonConvert.PopulateObject(values, _subject);

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var _subject = _db.Subjects.First(a => a.SubjectId == key);

            _db.Subjects.Remove(_subject);
            _db.SaveChanges();
        }

        [Route("ListExams")]
        public IActionResult ListExams(Guid id) => View(_db.Subjects.First(a => a.SubjectId == id));

        [Route("Details")]
        public IActionResult Index(Guid id)
        {
            var _subject = _db.Subjects.First(t => t.SubjectId == id);
            return View(_subject);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using ExamTesting.DAL;
using ExamTesting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace ExamTesting.FrontEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
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

        public IActionResult GetSubjects()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newSubject = new Subject();
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
               
    }
}





//        public IActionResult Index()
//        {
//            var subjList = _db.Subjects.ToList();
//            return View(subjList);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(Subject subjects)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Add(subjects);
//                await _db.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(subjects);


//        }

//        [HttpGet]
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if(id == null)
//            {
//                return NotFound();
//            }

//            var subject = await _db.Subjects.FindAsync(id);

//            if(subject == null)
//            {
//                return NotFound();
//            }

//            return View(subject);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(Guid id, Subject subject)
//        {
//            if (id != subject.SubjectId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid) //check that valid? for add to DB
//            {
//                _db.Update(subject);
//                await _db.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(subject);
//        }




//        [HttpGet]
//        public ActionResult GetLevel(DataSourceLoadOptions loadOptions)
//        {
//            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(new SelectList(Enum.GetValues(typeof(EnumLevel))), loadOptions)));
//        }
//    }
//}
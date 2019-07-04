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
        public IActionResult Index()
        {
            var subjList = _db.Subjects.ToList();
            return View(subjList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Subject subjects)
        {
            if (ModelState.IsValid)
            {
                _db.Add(subjects);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subjects);


        }

        [HttpGet]
        public ActionResult GetLevel(DataSourceLoadOptions loadOptions)
        {
            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(new SelectList(Enum.GetValues(typeof(EnumLevel))), loadOptions)));
        }
    }
}
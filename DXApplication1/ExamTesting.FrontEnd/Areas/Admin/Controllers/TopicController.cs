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
    public class TopicController : Controller
    {
        private readonly ExamTestingDbContext _db;

        public TopicController(ExamTestingDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var topicList = _db.Topics.ToList();
            return View(topicList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Topic topic)
        {
            if (ModelState.IsValid)
            {
                _db.Add(topic);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);


        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topic = await _db.Topics.FindAsync(id);

            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Topic topic)
        {
            if (id != topic.TopicId)
            {
                return NotFound();
            }

            if (ModelState.IsValid) //check that valid? for add to DB
            {
                _db.Update(topic);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topic);
        }




        [HttpGet]
        public ActionResult GetLevel(DataSourceLoadOptions loadOptions)
        {
            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(new SelectList(Enum.GetValues(typeof(EnumLevel))), loadOptions)));
        }
    }
}
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
    public class TopicsController : Controller
    {
        private readonly ExamTestingDbContext _db;
        public TopicsController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_db.Topics, loadOptions);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(string values)
        {
            var newTopic = new Topic();
            newTopic.TopicId = new Guid();

            JsonConvert.PopulateObject(values, newTopic);

            _db.Topics.Add(newTopic);
            _db.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Guid key, string values)
        {
            var _topic = _db.Topics.First(a => a.TopicId == key);

            JsonConvert.PopulateObject(values, _topic);

            _db.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete(Guid key)
        {
            var _topic = _db.Topics.First(a => a.TopicId == key);

            _db.Topics.Remove(_topic);
            _db.SaveChanges();
        }
                
                
    }
}































//{
//    [Area("Admin")]
//    public class TopicController : Controller
//    {
//        private readonly ExamTestingDbContext _db;

//        public TopicController(ExamTestingDbContext db)
//        {
//            _db = db;

//        }
//        public IActionResult Index()
//        {
//            var topicList = _db.Topics.ToList();
//            return View(topicList);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Create(Topic topic)
//        {
//            if (ModelState.IsValid)
//            {
//                _db.Add(topic);
//                await _db.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(topic);


//        }

//        [HttpGet]
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }

//            var topic = await _db.Topics.FindAsync(id);

//            if (topic == null)
//            {
//                return NotFound();
//            }

//            return View(topic);
//        }
//        [HttpPost]
//        public async Task<IActionResult> Edit(Guid id, Topic topic)
//        {
//            if (id != topic.TopicId)
//            {
//                return NotFound();
//            }

//            if (ModelState.IsValid) //check that valid? for add to DB
//            {
//                _db.Update(topic);
//                await _db.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            return View(topic);
//        }




//        [HttpGet]
//        public ActionResult GetLevel(DataSourceLoadOptions loadOptions)
//        {
//            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(new SelectList(Enum.GetValues(typeof(EnumLevel))), loadOptions)));
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamTesting.DAL;
using ExamTesting.FrontEnd.Areas.Authen.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting.FrontEnd.Areas.Authen.Controllers
{
    [Area("Authen")]
    public class RegisterController : Controller
    {

        private readonly ExamTestingDbContext _db;

        public RegisterController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {

            var loginViewModel = new LoginViewModel();
            //loginViewModel.Name = "I'm bun";

            return View(loginViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Process(LoginViewModel model)
        {
            if (model.PasswordCheck)
            {
                var newUser = new ExamTesting.Models.User()
                {
                    Id = Guid.NewGuid(),
                    Email = model.Email,
                    Name = model.Name,
                    Password = model.Password
                };
                _db.Users.Add(newUser);
                _db.SaveChanges();
            }
            else
            {
                return View("Index");
            }

            return RedirectToAction("Index", "SignIn", null);
        }
    }
}
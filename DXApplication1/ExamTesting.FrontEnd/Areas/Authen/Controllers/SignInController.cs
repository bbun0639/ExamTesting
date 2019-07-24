using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ExamTesting.DAL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting.FrontEnd.Areas.Authen.Controllers
{
    [Area("Authen")]
    public class SignInController : Controller
    {

        private readonly ExamTestingDbContext _db;

        public SignInController(ExamTestingDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost,ActionName("Index")]
        public async Task<IActionResult> SignIn()
        {

            if (CheckUser("pa@paa.com", "password"))
            {
                await ProcessSignIn("pPAP", "pa@pa.com", true);
                return RedirectToAction("Index","Home", new { area = "Admin"});
            }
            else
            {
                return Content("SignIn not Complete");
            }
          
        }

        private bool CheckUser(string email, string password)
        {
            if (email == "pa@pa.com" && password == "password")
            {
                return true;
            }
            return false;
        }

        private async Task ProcessSignIn(string name, string email,bool isAdmin)
        {
            var claims = new List<Claim> {
                    new Claim(ClaimTypes.Name,name ),
                     new Claim(ClaimTypes.Email,email ),
                };

            //if (isAdmin)
            //    claims.Add(new Claim(ClaimTypes.Role, "Administrator"));

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {

            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Admin");

        }


    }
}
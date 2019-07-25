using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ExamTesting.DAL;
using ExamTesting.FrontEnd.Areas.Authen.Models;
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

        [HttpPost, ActionName("Index")]
        public async Task<IActionResult> SignIn(LoginViewModel model)
        {
            var user = _db.Users
                .Where(u => u.Email == model.Email && u.Password == model.Password)
                .FirstOrDefault();

            if (user != null)
            {
                await ProcessSignIn(user);

                if (user.isAdmin)
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }
              
            }
            else
            {
                return Content("SignIn not Complete");
            }

        }
        

        private async Task ProcessSignIn(ExamTesting.Models.User user)
        {
            var claims = new List<Claim> {
                     new Claim(ClaimTypes.Name,user.Name ),
                     new Claim(ClaimTypes.Email,user.Email ),
                     new Claim(ClaimTypes.NameIdentifier,user.Id.ToString() 
                     ),
                };

            if (user.isAdmin)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
            }

                

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60), //Time Limit 
                //IsPersistent = true //Stay Always 
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace ExamTesting.FrontEnd.Controllers
{

    public class AuthenController : Controller
    {

        public async Task<IActionResult> SignIn()
        {

            if (CheckUser("pa@pa.com", "password"))
            {
                await ProcessSignIn("pPAP", "pa@pa.com");
                return Content("SignIn Complete");
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

            if(isAdmin)
                claims.Add(new Claim(ClaimTypes.Role, "Administrator")),

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
            return Content("Sign Out Complete");

        }


    }
}
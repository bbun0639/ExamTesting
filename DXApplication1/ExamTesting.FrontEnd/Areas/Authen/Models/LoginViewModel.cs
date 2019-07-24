using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTesting.FrontEnd.Areas.Authen.Models
{
    public class LoginViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ComfirmPassword { get; set; }

        public bool PasswordCheck => this.Password == this.ComfirmPassword;
    }
}

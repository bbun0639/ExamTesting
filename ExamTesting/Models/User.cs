using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamTesting.Models
{
    public class User
    {
   
        [Key]
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool isAdmin { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<UserExam> UserExams { get; set; }

        public void AddExams(List<Exam> examsList)
        {
            if (this.UserExams == null)
                this.UserExams = new List<UserExam>();
                       

            examsList.ForEach(exam =>
            {
                //Need checking eist question
                UserExam newUserExam = new UserExam()
                {
                    UserExamId = Guid.NewGuid(),
                     UserId = this.UserId,
                      ExamId = exam.ExamCodeId
                };

                UserExams.Add(newUserExam);
            });

        }

    }
}

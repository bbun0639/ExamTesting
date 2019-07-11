using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTesting.Models
{
    public class Choice 
    {
        [Key]
        public Guid ChoiceId { get; set; }
    

        public string ChoiceStr { get; set; }
       

        public Boolean IsCorrect { get; set; }


        public Guid QuestionId { get; set; }
        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
        
        public virtual ICollection<Choice> Choices { get; set; }
    }
}
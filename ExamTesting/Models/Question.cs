using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTesting.Models
{
    public class Question
    {
        [Key]
        public Guid QuestionId { get; set; }
        
        [Display(Name ="Question")]
        public string QuestionStr { get; set; }
        
        public string Hint { get; set; }


        public Guid? TopicId { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
        

        public QuestionType QuestionType { get; set; }

        [Display(Name = "Question Level")]
        public EnumLevel QuestionLevel { get; set; }

        public int QuestionPoint { get; set; }

        [JsonIgnore]
        public virtual ICollection<Choice> Choices { get; set; }


        [JsonIgnore]
        public virtual ICollection<QuestionExam> QuestionExams { get; set; }


    }
}
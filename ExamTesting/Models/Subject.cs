using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamTesting.Models
{
    public class Subject
    {
        [Key][Display(Name ="Subject")]
        public Guid SubjectId { get; set; }

        [Display(Name ="Subject")]
        public string SubjectName { get; set; }

        [Display(Name = "Level")]
        public EnumLevel SubjectLevels { get; set; }

        [JsonIgnore]
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
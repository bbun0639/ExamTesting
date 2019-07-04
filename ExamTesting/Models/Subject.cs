using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamTesting.Models
{
    public class Subject
    {
        [Key]
        public Guid SubjectId { get; set; }

        [Display(Name ="Subject")]
        public string SubjectName { get; set; }

        [Display(Name = "Level")]
        public EnumLevel SubjectLevels { get; set; }

    }
}
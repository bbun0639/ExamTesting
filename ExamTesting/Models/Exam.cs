using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTesting.Models
{
    public class Exam
    {
        [Key]
        public Guid ExamCodeId { get; set; }


        public string ExamName { get; set; }


        public int ExamVersion { get; set; }

        public Guid SubjectId { get; set; }
        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
        
    }
}
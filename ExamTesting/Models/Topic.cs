using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExamTesting.Models
{
    public class Topic
    {
        [Key]
        public Guid TopicId { get; set; }

        public Guid? ParentId { get; set; }        
        public Guid? ChildId { get; set; }
                
        public string TopicName { get; set; }
    }
}
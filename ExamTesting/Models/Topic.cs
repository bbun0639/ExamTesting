using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ExamTesting.Models
{
    public class Topic
    {
        [Key]
        [DisplayName("Topic")]
        public Guid TopicId { get; set; }

        public Guid? ParentId { get; set; }
        [ForeignKey("ParentId")]
        [JsonIgnore]
        public virtual Topic Parent { get; set; }

        [JsonIgnore]
        public virtual ICollection<Topic> Childs { get; set; }

        public string TopicName { get; set; }
    }
}
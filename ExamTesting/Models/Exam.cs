using Newtonsoft.Json;
using System;
using System.Collections;
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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<QuestionExam> QuestionsExams { get; set; }


        public void AddQuestionns(List<Question> questionsList)
        {
            if (this.QuestionsExams == null)
                this.QuestionsExams = new List<QuestionExam>();



            questionsList.ForEach(q =>
            {
                //Need checking eist question
                QuestionExam newQuestionExam = new QuestionExam()
                {
                    QuestionExamId = Guid.NewGuid(),
                    ExamId = this.ExamCodeId,
                    QuestionId = q.QuestionId
                };

                QuestionsExams.Add(newQuestionExam);
            });

        }
    }
}
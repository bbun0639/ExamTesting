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
        public int ExamDuration { get; set; }

        [NotMapped]
        public DateTime EndDate => StartDate.AddDays(ExamDuration);

        [NotMapped]
        public int RemainingDay => (EndDate - DateTime.Today).Days;

        [JsonIgnore]
        public virtual ICollection<QuestionExam> QuestionsExams { get; set; }

        public string ExamCode { get; set; }

        public int PercentPass { get; set; }



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
        

        [JsonIgnore]
        public virtual ICollection<UserExam> UserExams { get; set; }



        public void AddQuestions(List<Question> questionsList)
        {
            //if null => add new
            if (this.QuestionsExams == null)
                this.QuestionsExams = new List<QuestionExam>();

            questionsList.ForEach(question =>
            {
                //Need checking list question


                QuestionExam newQuestionExam = new QuestionExam()
                {
                    QuestionExamId = Guid.NewGuid(),
                    ExamId = this.ExamCodeId,
                    QuestionId = question.QuestionId
                };

                QuestionsExams.Add(newQuestionExam);

            });

        }
    }
}
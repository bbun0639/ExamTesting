using ExamTesting.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTesting.DAL
{
    public class ExamTestingDbContext : DbContext
    {
        public DbSet<Choice> Choices { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionExam> QuestionExams { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserExam> UserExams { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=ExamTesting;Trusted_Connection=True;").UseLazyLoadingProxies();
        }
    }
}

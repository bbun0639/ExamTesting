﻿// <auto-generated />
using System;
using ExamTesting.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamTesting.Migrations
{
    [DbContext(typeof(ExamTestingDbContext))]
    partial class ExamTestingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamTesting.Models.Choice", b =>
                {
                    b.Property<Guid>("ChoiceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChoiceStr");

                    b.Property<bool>("IsCorrect");

                    b.Property<Guid>("QuestionId");

                    b.HasKey("ChoiceId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("ExamTesting.Models.Exam", b =>
                {
                    b.Property<Guid>("ExamCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExamDuration");

                    b.Property<string>("ExamName");

                    b.Property<int>("ExamVersion");

                    b.Property<DateTime>("StartDate");

                    b.Property<Guid>("SubjectId");

                    b.HasKey("ExamCodeId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("ExamTesting.Models.Question", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Hint");

                    b.Property<int>("QuestionLevel");

                    b.Property<int>("QuestionPoint");

                    b.Property<string>("QuestionStr");

                    b.Property<int>("QuestionType");

                    b.Property<Guid?>("TopicId");

                    b.HasKey("QuestionId");

                    b.HasIndex("TopicId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ExamTesting.Models.QuestionExam", b =>
                {
                    b.Property<Guid>("QuestionExamId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ExamId");

                    b.Property<Guid>("QuestionId");

                    b.Property<Guid>("TopicId");

                    b.HasKey("QuestionExamId");

                    b.HasIndex("ExamId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TopicId");

                    b.ToTable("QuestionExams");
                });

            modelBuilder.Entity("ExamTesting.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SubjectLevels");

                    b.Property<string>("SubjectName");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ExamTesting.Models.Topic", b =>
                {
                    b.Property<Guid>("TopicId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ParentId");

                    b.Property<string>("TopicName");

                    b.HasKey("TopicId");

                    b.HasIndex("ParentId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("ExamTesting.Models.Choice", b =>
                {
                    b.HasOne("ExamTesting.Models.Question", "Question")
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExamTesting.Models.Exam", b =>
                {
                    b.HasOne("ExamTesting.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExamTesting.Models.Question", b =>
                {
                    b.HasOne("ExamTesting.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId");
                });

            modelBuilder.Entity("ExamTesting.Models.QuestionExam", b =>
                {
                    b.HasOne("ExamTesting.Models.Exam", "Exam")
                        .WithMany("QuestionsExams")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExamTesting.Models.Question", "Question")
                        .WithMany("QuestionExams")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ExamTesting.Models.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExamTesting.Models.Topic", b =>
                {
                    b.HasOne("ExamTesting.Models.Topic", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}

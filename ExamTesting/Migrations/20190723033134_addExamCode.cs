using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addExamCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionExams_Topics_TopicId",
                table: "QuestionExams");

            migrationBuilder.DropIndex(
                name: "IX_QuestionExams_TopicId",
                table: "QuestionExams");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "QuestionExams");

            migrationBuilder.AddColumn<string>(
                name: "ExamCode",
                table: "Exams",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExamCode",
                table: "Exams");

            migrationBuilder.AddColumn<Guid>(
                name: "TopicId",
                table: "QuestionExams",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_QuestionExams_TopicId",
                table: "QuestionExams",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionExams_Topics_TopicId",
                table: "QuestionExams",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addUserExamQuestionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserExamId",
                table: "UserExams",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "TotalEarnScore",
                table: "UserExams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalQuestionScore",
                table: "UserExams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserExamQuestions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserExamId = table.Column<Guid>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: false),
                    SelectChoiceId = table.Column<Guid>(nullable: true),
                    EarnScore = table.Column<int>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserExamQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExamQuestions_UserExams_UserExamId",
                        column: x => x.UserExamId,
                        principalTable: "UserExams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserExamQuestions_QuestionId",
                table: "UserExamQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExamQuestions_UserExamId",
                table: "UserExamQuestions",
                column: "UserExamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserExamQuestions");

            migrationBuilder.DropColumn(
                name: "TotalEarnScore",
                table: "UserExams");

            migrationBuilder.DropColumn(
                name: "TotalQuestionScore",
                table: "UserExams");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserExams",
                newName: "UserExamId");
        }
    }
}

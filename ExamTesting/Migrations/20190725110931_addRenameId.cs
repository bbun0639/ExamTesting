using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addRenameId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserExams",
                newName: "UserExamId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserExamQuestions",
                newName: "UserExamQuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserExamId",
                table: "UserExams",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserExamQuestionId",
                table: "UserExamQuestions",
                newName: "Id");
        }
    }
}

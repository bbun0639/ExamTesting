using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addIsComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsComplete",
                table: "UserExamQuestions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsComplete",
                table: "UserExamQuestions");
        }
    }
}

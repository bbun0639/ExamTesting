using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class movepropPercentPass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentPass",
                table: "UserExams");

            migrationBuilder.AddColumn<int>(
                name: "PercentPass",
                table: "Exams",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentPass",
                table: "Exams");

            migrationBuilder.AddColumn<int>(
                name: "PercentPass",
                table: "UserExams",
                nullable: false,
                defaultValue: 0);
        }
    }
}

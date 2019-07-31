using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addpropPercent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PercentPass",
                table: "UserExams",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PercentPass",
                table: "UserExams");
        }
    }
}

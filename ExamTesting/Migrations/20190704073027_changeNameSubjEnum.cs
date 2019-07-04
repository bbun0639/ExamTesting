using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class changeNameSubjEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectLevel",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "SubjectLevels",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectLevels",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "SubjectLevel",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);
        }
    }
}

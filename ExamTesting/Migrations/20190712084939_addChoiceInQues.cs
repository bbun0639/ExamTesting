using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addChoiceInQues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExamCodeId",
                table: "Choices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Choices_ExamCodeId",
                table: "Choices",
                column: "ExamCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Exams_ExamCodeId",
                table: "Choices",
                column: "ExamCodeId",
                principalTable: "Exams",
                principalColumn: "ExamCodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Exams_ExamCodeId",
                table: "Choices");

            migrationBuilder.DropIndex(
                name: "IX_Choices_ExamCodeId",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "ExamCodeId",
                table: "Choices");
        }
    }
}

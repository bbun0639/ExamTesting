using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class delICollectionChoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Choices_ChoiceId1",
                table: "Choices");

            migrationBuilder.DropIndex(
                name: "IX_Choices_ChoiceId1",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "ChoiceId1",
                table: "Choices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChoiceId1",
                table: "Choices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Choices_ChoiceId1",
                table: "Choices",
                column: "ChoiceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Choices_ChoiceId1",
                table: "Choices",
                column: "ChoiceId1",
                principalTable: "Choices",
                principalColumn: "ChoiceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

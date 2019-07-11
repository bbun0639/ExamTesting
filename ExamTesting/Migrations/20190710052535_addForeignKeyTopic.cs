using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamTesting.Migrations
{
    public partial class addForeignKeyTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Topics");

            migrationBuilder.AddColumn<Guid>(
                name: "ChoiceId1",
                table: "Choices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ParentId",
                table: "Topics",
                column: "ParentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Topics_ParentId",
                table: "Topics",
                column: "ParentId",
                principalTable: "Topics",
                principalColumn: "TopicId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Choices_ChoiceId1",
                table: "Choices");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Topics_ParentId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_ParentId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Choices_ChoiceId1",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "ChoiceId1",
                table: "Choices");

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "Topics",
                nullable: true);
        }
    }
}

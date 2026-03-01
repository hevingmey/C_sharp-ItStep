using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson_sql.Migrations
{
    /// <inheritdoc />
    public partial class addtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Students_studentId",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Subject_subjectId",
                table: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Grade_studentId",
                table: "Grade");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Grade_Value",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "dateAsigned",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "value",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "subjectId",
                table: "Grade",
                newName: "studentsid");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Grade",
                newName: "coursesId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_subjectId",
                table: "Grade",
                newName: "IX_Grade_studentsid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                columns: new[] { "coursesId", "studentsid" });

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Students_studentsid",
                table: "Grade",
                column: "studentsid",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Subject_coursesId",
                table: "Grade",
                column: "coursesId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Students_studentsid",
                table: "Grade");

            migrationBuilder.DropForeignKey(
                name: "FK_Grade_Subject_coursesId",
                table: "Grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "studentsid",
                table: "Grade",
                newName: "subjectId");

            migrationBuilder.RenameColumn(
                name: "coursesId",
                table: "Grade",
                newName: "studentId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_studentsid",
                table: "Grade",
                newName: "IX_Grade_subjectId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Grade",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "dateAsigned",
                table: "Grade",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "Grade",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_studentId",
                table: "Grade",
                column: "studentId");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Grade_Value",
                table: "Grade",
                sql: "[Value] between 1 and 12");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Students_studentId",
                table: "Grade",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_Subject_subjectId",
                table: "Grade",
                column: "subjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

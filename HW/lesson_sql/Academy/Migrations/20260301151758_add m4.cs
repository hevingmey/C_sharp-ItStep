using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson_sql.Migrations
{
    /// <inheritdoc />
    public partial class addm4 : Migration
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
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grade",
                table: "Grade");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Grade",
                newName: "Grades");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_subjectId",
                table: "Grades",
                newName: "IX_Grades_subjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_studentId",
                table: "Grades",
                newName: "IX_Grades_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Subjects_subjectId",
                table: "Grades",
                column: "subjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_studentId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Subjects_subjectId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "Grade");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_subjectId",
                table: "Grade",
                newName: "IX_Grade_subjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Grades_studentId",
                table: "Grade",
                newName: "IX_Grade_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grade",
                table: "Grade",
                column: "Id");

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

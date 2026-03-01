using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson_sql.Migrations
{
    /// <inheritdoc />
    public partial class dtcomp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropColumn(
                name: "GrouoId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "createdAdd",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "groupId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "dateOfBirth",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "curatorId",
                table: "Group",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Curators",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    groupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curators", x => x.id);
                    table.ForeignKey(
                        name: "FK_Curators_Group_groupId",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<int>(type: "int", nullable: true),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    subjectId = table.Column<int>(type: "int", nullable: false),
                    dateAsigned = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.CheckConstraint("CK_Grade_Value", "[Value] between 1 and 12");
                    table.ForeignKey(
                        name: "FK_Grade_Students_studentId",
                        column: x => x.studentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Grade_Subject_subjectId",
                        column: x => x.subjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Curators_groupId",
                table: "Curators",
                column: "groupId",
                unique: true,
                filter: "[groupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_studentId",
                table: "Grade",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grade_subjectId",
                table: "Grade",
                column: "subjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Curators");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropColumn(
                name: "dateOfBirth",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "curatorId",
                table: "Group");

            migrationBuilder.AlterColumn<int>(
                name: "groupId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrouoId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAdd",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

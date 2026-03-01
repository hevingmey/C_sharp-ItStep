using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lesson_sql.Migrations
{
    /// <inheritdoc />
    public partial class addnewmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "groupId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_groupId",
                table: "Students",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Group_groupId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Students_groupId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "GrouoId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "groupId",
                table: "Students");
        }
    }
}

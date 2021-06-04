using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class VakStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Locaties",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "VakStudenten",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    VakId = table.Column<int>(type: "int", nullable: false),
                    Uren = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VakStudenten", x => new { x.StudentId, x.VakId });
                    table.ForeignKey(
                        name: "FK_VakStudenten_Studenten_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Studenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VakStudenten_Vakken_VakId",
                        column: x => x.VakId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VakStudenten_VakId",
                table: "VakStudenten",
                column: "VakId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VakStudenten");

            migrationBuilder.AlterColumn<string>(
                name: "Naam",
                table: "Locaties",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}

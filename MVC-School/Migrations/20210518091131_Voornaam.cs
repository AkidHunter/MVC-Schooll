using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class Voornaam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "Locaties",
                newName: "Voornaam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Voornaam",
                table: "Locaties",
                newName: "Naam");
        }
    }
}

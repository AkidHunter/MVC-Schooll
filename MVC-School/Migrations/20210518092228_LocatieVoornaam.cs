using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class LocatieVoornaam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achternaam",
                table: "Locaties");

            migrationBuilder.RenameColumn(
                name: "Voornaam",
                table: "Locaties",
                newName: "Naam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naam",
                table: "Locaties",
                newName: "Voornaam");

            migrationBuilder.AddColumn<string>(
                name: "Achternaam",
                table: "Locaties",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}

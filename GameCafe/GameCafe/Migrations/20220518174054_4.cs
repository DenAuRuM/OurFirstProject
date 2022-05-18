using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCafe.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sparkling",
                table: "Drinks",
                newName: "Sparkling");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sparkling",
                table: "Drinks",
                newName: "Sparkling");
        }
    }
}

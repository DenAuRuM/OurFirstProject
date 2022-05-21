using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCafe.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideogameId",
                table: "VideoGameGenres");

           
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Drinks");

            migrationBuilder.AddColumn<int>(
                name: "VideogameId",
                table: "VideoGameGenres",
                type: "int",
                nullable: true);
        }
    }
}

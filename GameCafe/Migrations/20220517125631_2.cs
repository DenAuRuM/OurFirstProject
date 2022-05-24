using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCafe.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames");

            migrationBuilder.DropIndex(
                name: "IX_Videogames_VideoGameGenreId",
                table: "Videogames");

            migrationBuilder.DropColumn(
                name: "VideoGameGenreId",
                table: "Videogames");

            migrationBuilder.DropColumn(
                name: "VideogameId",
                table: "VideoGameGenres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VideoGameGenreId",
                table: "Videogames",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideogameId",
                table: "VideoGameGenres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Videogames_VideoGameGenreId",
                table: "Videogames",
                column: "VideoGameGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames",
                column: "VideoGameGenreId",
                principalTable: "VideoGameGenres",
                principalColumn: "Id");
        }
    }
}

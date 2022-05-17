using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCafe.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Places_PlaceId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_PlaceId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Reviews");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PlaceId",
                table: "Reviews",
                column: "PlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Places_PlaceId",
                table: "Reviews",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

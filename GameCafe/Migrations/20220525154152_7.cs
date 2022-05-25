using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameCafe.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames");

            migrationBuilder.AlterColumn<int>(
                name: "VideoGameGenreId",
                table: "Videogames",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames",
                column: "VideoGameGenreId",
                principalTable: "VideoGameGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames");

            migrationBuilder.AlterColumn<int>(
                name: "VideoGameGenreId",
                table: "Videogames",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Videogames_VideoGameGenres_VideoGameGenreId",
                table: "Videogames",
                column: "VideoGameGenreId",
                principalTable: "VideoGameGenres",
                principalColumn: "Id");
        }
    }
}

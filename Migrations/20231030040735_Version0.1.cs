using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_MainCategory_filmMainCategoryId",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MainCategory",
                table: "MainCategory");

            migrationBuilder.RenameTable(
                name: "MainCategory",
                newName: "FilmMainCategory");

            migrationBuilder.AlterColumn<string>(
                name: "filmMainCategoryName",
                table: "FilmMainCategory",
                type: "NVARCHAR(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmMainCategory",
                table: "FilmMainCategory",
                column: "filmMainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_FilmMainCategory_filmMainCategoryId",
                table: "Film",
                column: "filmMainCategoryId",
                principalTable: "FilmMainCategory",
                principalColumn: "filmMainCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Film_FilmMainCategory_filmMainCategoryId",
                table: "Film");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmMainCategory",
                table: "FilmMainCategory");

            migrationBuilder.RenameTable(
                name: "FilmMainCategory",
                newName: "MainCategory");

            migrationBuilder.AlterColumn<string>(
                name: "filmMainCategoryName",
                table: "MainCategory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MainCategory",
                table: "MainCategory",
                column: "filmMainCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Film_MainCategory_filmMainCategoryId",
                table: "Film",
                column: "filmMainCategoryId",
                principalTable: "MainCategory",
                principalColumn: "filmMainCategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

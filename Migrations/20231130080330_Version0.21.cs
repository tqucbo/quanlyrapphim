using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filmBannerImage",
                table: "Film",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filmBannerImage",
                table: "Film");
        }
    }
}

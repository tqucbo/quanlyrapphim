using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "FilmSchedule");

            migrationBuilder.AddColumn<int>(
                name: "seatCategoryPrice",
                table: "SeatCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seatCategoryPrice",
                table: "SeatCategory");

            migrationBuilder.AddColumn<int>(
                name: "price",
                table: "FilmSchedule",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

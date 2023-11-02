using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version09c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "filmShowDate2",
                table: "FilmSchedule",
                newName: "filmShowDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "filmShowDate",
                table: "FilmSchedule",
                newName: "filmShowDate2");
        }
    }
}

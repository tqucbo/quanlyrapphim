using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filmShowTime",
                table: "FilmSchedule");

            migrationBuilder.AddColumn<string>(
                name: "cinemaRoomId",
                table: "FilmSchedule",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FilmSchedule_cinemaRoomId",
                table: "FilmSchedule",
                column: "cinemaRoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmSchedule_CinemaRoom_cinemaRoomId",
                table: "FilmSchedule",
                column: "cinemaRoomId",
                principalTable: "CinemaRoom",
                principalColumn: "cinemaRoomId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmSchedule_CinemaRoom_cinemaRoomId",
                table: "FilmSchedule");

            migrationBuilder.DropIndex(
                name: "IX_FilmSchedule_cinemaRoomId",
                table: "FilmSchedule");

            migrationBuilder.DropColumn(
                name: "cinemaRoomId",
                table: "FilmSchedule");

            migrationBuilder.AddColumn<DateTime>(
                name: "filmShowTime",
                table: "FilmSchedule",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

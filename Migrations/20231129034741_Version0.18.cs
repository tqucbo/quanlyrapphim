using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "orderDate",
                table: "Invoice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "orderTime",
                table: "Invoice",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "orderDate",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "orderTime",
                table: "Invoice");
        }
    }
}

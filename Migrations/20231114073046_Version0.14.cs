using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Film_filmId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_filmId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "filmId",
                table: "Ticket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filmId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_filmId",
                table: "Ticket",
                column: "filmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Film_filmId",
                table: "Ticket",
                column: "filmId",
                principalTable: "Film",
                principalColumn: "filmId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

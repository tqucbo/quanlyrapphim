using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "seatCategoryId",
                table: "Seat",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SeatCategory",
                columns: table => new
                {
                    seatCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    seatCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatCategory", x => x.seatCategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seat_seatCategoryId",
                table: "Seat",
                column: "seatCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_SeatCategory_seatCategoryId",
                table: "Seat",
                column: "seatCategoryId",
                principalTable: "SeatCategory",
                principalColumn: "seatCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_SeatCategory_seatCategoryId",
                table: "Seat");

            migrationBuilder.DropTable(
                name: "SeatCategory");

            migrationBuilder.DropIndex(
                name: "IX_Seat_seatCategoryId",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "seatCategoryId",
                table: "Seat");
        }
    }
}

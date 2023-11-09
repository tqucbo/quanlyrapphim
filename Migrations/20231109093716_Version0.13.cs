using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    invoiceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ticketId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => new { x.invoiceId, x.ticketId });
                    table.ForeignKey(
                        name: "FK_Invoice_Ticket_ticketId",
                        column: x => x.ticketId,
                        principalTable: "Ticket",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_ticketId",
                table: "Invoice",
                column: "ticketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoice");
        }
    }
}

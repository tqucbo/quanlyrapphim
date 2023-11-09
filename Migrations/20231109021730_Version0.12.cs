using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    paymentMethodId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    paymentMethodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentMethodNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.paymentMethodId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethod");
        }
    }
}

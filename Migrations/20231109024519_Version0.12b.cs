using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version012b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "paymentMethodImage",
                table: "PaymentMethod",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "paymentMethodImage",
                table: "PaymentMethod");
        }
    }
}

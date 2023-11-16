using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version015b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "paymentMethodId",
                table: "Invoice",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_paymentMethodId",
                table: "Invoice",
                column: "paymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_PaymentMethod_paymentMethodId",
                table: "Invoice",
                column: "paymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "paymentMethodId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_PaymentMethod_paymentMethodId",
                table: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_paymentMethodId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "paymentMethodId",
                table: "Invoice");
        }
    }
}

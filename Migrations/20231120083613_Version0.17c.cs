using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version017c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Users_appUserId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_appUserId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "appUserId",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "accountId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_accountId",
                table: "Ticket",
                column: "accountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Users_accountId",
                table: "Ticket",
                column: "accountId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Users_accountId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_accountId",
                table: "Ticket");

            migrationBuilder.AlterColumn<string>(
                name: "accountId",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "appUserId",
                table: "Ticket",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_appUserId",
                table: "Ticket",
                column: "appUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Users_appUserId",
                table: "Ticket",
                column: "appUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

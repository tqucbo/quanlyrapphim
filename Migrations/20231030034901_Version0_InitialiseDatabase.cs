using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyRapPhim.Migrations
{
    public partial class Version0_InitialiseDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    accountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    accountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountPeopleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountMembershipPoint = table.Column<int>(type: "int", nullable: false),
                    accountAdmin = table.Column<bool>(type: "bit", nullable: false),
                    accountPasswordHashed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.accountId);
                });

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    cinemaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cinemaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cinemaAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.cinemaId);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenre",
                columns: table => new
                {
                    filmGenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filmGenreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmGenreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenre", x => x.filmGenreId);
                });

            migrationBuilder.CreateTable(
                name: "MainCategory",
                columns: table => new
                {
                    filmMainCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filmMainCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategory", x => x.filmMainCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CinemaRoom",
                columns: table => new
                {
                    cinemaRoomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cinemaRoomName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cinemaId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaRoom", x => x.cinemaRoomId);
                    table.ForeignKey(
                        name: "FK_CinemaRoom_Cinema_cinemaId",
                        column: x => x.cinemaId,
                        principalTable: "Cinema",
                        principalColumn: "cinemaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    filmId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmLength = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmMainCategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    filmDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    filmGenreId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    filmDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmMainActors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filmPosterImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.filmId);
                    table.ForeignKey(
                        name: "FK_Film_FilmGenre_filmGenreId",
                        column: x => x.filmGenreId,
                        principalTable: "FilmGenre",
                        principalColumn: "filmGenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Film_MainCategory_filmMainCategoryId",
                        column: x => x.filmMainCategoryId,
                        principalTable: "MainCategory",
                        principalColumn: "filmMainCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    seatId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    seatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    seatColumnNumber = table.Column<int>(type: "int", nullable: false),
                    seatRowChar = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    cinemaRoomId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.seatId);
                    table.ForeignKey(
                        name: "FK_Seat_CinemaRoom_cinemaRoomId",
                        column: x => x.cinemaRoomId,
                        principalTable: "CinemaRoom",
                        principalColumn: "cinemaRoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmSchedule",
                columns: table => new
                {
                    filmSecheduleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filmShowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    filmShowTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    filmId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmSchedule", x => x.filmSecheduleId);
                    table.ForeignKey(
                        name: "FK_FilmSchedule_Film_filmId",
                        column: x => x.filmId,
                        principalTable: "Film",
                        principalColumn: "filmId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ticketId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    filmId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    accountId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    seatId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    filmSecheduleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ticketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Account_accountId",
                        column: x => x.accountId,
                        principalTable: "Account",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Film_filmId",
                        column: x => x.filmId,
                        principalTable: "Film",
                        principalColumn: "filmId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_FilmSchedule_filmSecheduleId",
                        column: x => x.filmSecheduleId,
                        principalTable: "FilmSchedule",
                        principalColumn: "filmSecheduleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ticket_Seat_seatId",
                        column: x => x.seatId,
                        principalTable: "Seat",
                        principalColumn: "seatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaRoom_cinemaId",
                table: "CinemaRoom",
                column: "cinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_filmGenreId",
                table: "Film",
                column: "filmGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Film_filmMainCategoryId",
                table: "Film",
                column: "filmMainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmSchedule_filmId",
                table: "FilmSchedule",
                column: "filmId");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_cinemaRoomId",
                table: "Seat",
                column: "cinemaRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_accountId",
                table: "Ticket",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_filmId",
                table: "Ticket",
                column: "filmId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_filmSecheduleId",
                table: "Ticket",
                column: "filmSecheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_seatId",
                table: "Ticket",
                column: "seatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "FilmSchedule");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "CinemaRoom");

            migrationBuilder.DropTable(
                name: "FilmGenre");

            migrationBuilder.DropTable(
                name: "MainCategory");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}

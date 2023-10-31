﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyRapPhim.Data;

namespace QuanLyRapPhim.Migrations
{
    [DbContext(typeof(QuanLyRapPhimDBContext))]
    partial class QuanLyRapPhimDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyRapPhim.Models.AccountModel", b =>
                {
                    b.Property<string>("accountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accountAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("accountAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("accountEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("accountMembershipPoint")
                        .HasColumnType("int");

                    b.Property<string>("accountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountPasswordHashed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountPeopleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("accountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.CinemaModel", b =>
                {
                    b.Property<string>("cinemaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cinemaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cinemaId");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.CinemaRoomModel", b =>
                {
                    b.Property<string>("cinemaRoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaRoomName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cinemaRoomId");

                    b.HasIndex("cinemaId");

                    b.ToTable("CinemaRoom");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmGenreModel", b =>
                {
                    b.Property<string>("filmGenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmGenreDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmGenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("filmGenreId");

                    b.ToTable("FilmGenre");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmMainCategoryModel", b =>
                {
                    b.Property<string>("filmMainCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmMainCategoryName")
                        .HasMaxLength(450)
                        .HasColumnType("NVARCHAR(450)");

                    b.HasKey("filmMainCategoryId");

                    b.ToTable("FilmMainCategory");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmModel", b =>
                {
                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmDirector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmGenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("filmLength")
                        .HasColumnType("int");

                    b.Property<string>("filmMainActors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmMainCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmPosterImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("filmStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("filmId");

                    b.HasIndex("filmGenreId");

                    b.HasIndex("filmMainCategoryId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmSecheduleModel", b =>
                {
                    b.Property<string>("filmSecheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaRoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("filmShowDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("filmSecheduleId");

                    b.HasIndex("cinemaRoomId");

                    b.HasIndex("filmId");

                    b.ToTable("FilmSchedule");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.SeatModel", b =>
                {
                    b.Property<string>("seatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaRoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("seatColumnNumber")
                        .HasColumnType("int");

                    b.Property<string>("seatName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seatRowChar")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("seatId");

                    b.HasIndex("cinemaRoomId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.TicketModel", b =>
                {
                    b.Property<string>("ticketId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmSecheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("seatId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ticketId");

                    b.HasIndex("accountId");

                    b.HasIndex("filmId");

                    b.HasIndex("filmSecheduleId");

                    b.HasIndex("seatId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.CinemaRoomModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.CinemaModel", "cinemaModel")
                        .WithMany()
                        .HasForeignKey("cinemaId");

                    b.Navigation("cinemaModel");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.FilmGenreModel", "filmGenre")
                        .WithMany()
                        .HasForeignKey("filmGenreId");

                    b.HasOne("QuanLyRapPhim.Models.FilmMainCategoryModel", "filmMainCategory")
                        .WithMany()
                        .HasForeignKey("filmMainCategoryId");

                    b.Navigation("filmGenre");

                    b.Navigation("filmMainCategory");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.FilmSecheduleModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.CinemaRoomModel", "CinemaRoom")
                        .WithMany()
                        .HasForeignKey("cinemaRoomId");

                    b.HasOne("QuanLyRapPhim.Models.FilmModel", "film")
                        .WithMany()
                        .HasForeignKey("filmId");

                    b.Navigation("CinemaRoom");

                    b.Navigation("film");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.SeatModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.CinemaRoomModel", "cinemaRoom")
                        .WithMany()
                        .HasForeignKey("cinemaRoomId");

                    b.Navigation("cinemaRoom");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.TicketModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.AccountModel", "account")
                        .WithMany()
                        .HasForeignKey("accountId");

                    b.HasOne("QuanLyRapPhim.Models.FilmModel", "film")
                        .WithMany()
                        .HasForeignKey("filmId");

                    b.HasOne("QuanLyRapPhim.Models.FilmSecheduleModel", "filmSechedule")
                        .WithMany()
                        .HasForeignKey("filmSecheduleId");

                    b.HasOne("QuanLyRapPhim.Models.SeatModel", "seat")
                        .WithMany()
                        .HasForeignKey("seatId");

                    b.Navigation("account");

                    b.Navigation("film");

                    b.Navigation("filmSechedule");

                    b.Navigation("seat");
                });
#pragma warning restore 612, 618
        }
    }
}

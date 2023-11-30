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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.CinemaModel", b =>
                {
                    b.Property<string>("cinemaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cinemaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cinemaServiceCharge")
                        .HasColumnType("int");

                    b.Property<string>("image")
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

                    b.Property<string>("filmBannerImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filmCountry")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("languageSubtitle")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("DATE");

                    b.Property<TimeSpan>("filmShowTime")
                        .HasColumnType("TIME");

                    b.HasKey("filmSecheduleId");

                    b.HasIndex("cinemaRoomId");

                    b.HasIndex("filmId");

                    b.ToTable("FilmSchedule");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.InvoiceModel", b =>
                {
                    b.Property<string>("invoiceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ticketId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("orderDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("orderTime")
                        .HasColumnType("time");

                    b.Property<string>("paymentMethodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("invoiceId", "ticketId");

                    b.HasIndex("paymentMethodId");

                    b.HasIndex("ticketId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.PaymentMethodModel", b =>
                {
                    b.Property<string>("paymentMethodId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("paymentMethodImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paymentMethodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paymentMethodNote")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("paymentMethodId");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.SeatCategoryModel", b =>
                {
                    b.Property<string>("seatCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("seatCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("seatCategoryPrice")
                        .HasColumnType("int");

                    b.HasKey("seatCategoryId");

                    b.ToTable("SeatCategory");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.SeatModel", b =>
                {
                    b.Property<string>("seatId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("cinemaRoomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("seatCategoryId")
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

                    b.HasIndex("seatCategoryId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.TicketModel", b =>
                {
                    b.Property<string>("ticketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("accountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("filmSecheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("seatId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ticketId");

                    b.HasIndex("accountId");

                    b.HasIndex("filmSecheduleId");

                    b.HasIndex("seatId");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.AppUserModel", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("peopleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUserModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("QuanLyRapPhim.Models.InvoiceModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.PaymentMethodModel", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("paymentMethodId");

                    b.HasOne("QuanLyRapPhim.Models.TicketModel", "ticket")
                        .WithMany()
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentMethod");

                    b.Navigation("ticket");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.SeatModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.CinemaRoomModel", "cinemaRoom")
                        .WithMany()
                        .HasForeignKey("cinemaRoomId");

                    b.HasOne("QuanLyRapPhim.Models.SeatCategoryModel", "seatCategory")
                        .WithMany()
                        .HasForeignKey("seatCategoryId");

                    b.Navigation("cinemaRoom");

                    b.Navigation("seatCategory");
                });

            modelBuilder.Entity("QuanLyRapPhim.Models.TicketModel", b =>
                {
                    b.HasOne("QuanLyRapPhim.Models.AppUserModel", "appUser")
                        .WithMany()
                        .HasForeignKey("accountId");

                    b.HasOne("QuanLyRapPhim.Models.FilmSecheduleModel", "filmSechedule")
                        .WithMany()
                        .HasForeignKey("filmSecheduleId");

                    b.HasOne("QuanLyRapPhim.Models.SeatModel", "seat")
                        .WithMany()
                        .HasForeignKey("seatId");

                    b.Navigation("appUser");

                    b.Navigation("filmSechedule");

                    b.Navigation("seat");
                });
#pragma warning restore 612, 618
        }
    }
}

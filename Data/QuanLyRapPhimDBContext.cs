
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using QuanLyRapPhim.Models;

namespace QuanLyRapPhim.Data
{
    public class QuanLyRapPhimDBContext : DbContext
    {
        public QuanLyRapPhimDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<AccountModel> accounts { set; get; }

        public DbSet<CinemaModel> cinemas { set; get; }

        public DbSet<CinemaRoomModel> cinemaRooms { set; get; }

        public DbSet<FilmGenreModel> filmGenres { set; get; }

        public DbSet<FilmMainCategoryModel> filmMainCategories { set; get; }

        public DbSet<FilmModel> films { set; get; }

        public DbSet<FilmSecheduleModel> filmSechedules { set; get; }

        public DbSet<SeatModel> seats { set; get; }

        public DbSet<TicketModel> tickets { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    entityType.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
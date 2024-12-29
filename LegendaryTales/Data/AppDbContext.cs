using LegendaryTales.Models;
using Microsoft.EntityFrameworkCore;

namespace LegendaryTales.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasMany(p => p.Items)
                .WithMany(i => i.Players);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using CarStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string? _connectionString;
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Car> Cars { get; set; }

        public AppDbContext(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            opBuilder.UseSqlServer(_connectionString);
        }


    }
}

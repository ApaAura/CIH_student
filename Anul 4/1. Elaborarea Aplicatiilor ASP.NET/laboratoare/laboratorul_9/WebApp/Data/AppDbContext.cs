using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class AppDbContext :DbContext
    {
        private readonly string? _connectionString;

        public DbSet<Student> Students { get; set; }

        public AppDbContext(string? connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opBuilder)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = _connectionString };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            opBuilder.UseSqlite(connection);
        }
    }
}

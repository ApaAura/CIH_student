using BookStore.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class AppDBContext : DbContext
{
    private readonly string? _connectionString;

    public DbSet<Book> Books { get; set; }

    public AppDBContext(string? connectionString)
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

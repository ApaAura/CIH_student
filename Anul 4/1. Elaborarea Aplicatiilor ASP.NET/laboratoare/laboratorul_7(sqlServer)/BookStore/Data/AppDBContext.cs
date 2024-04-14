using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

public class AppDBContext: DbContext
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
        opBuilder.UseSqlServer(_connectionString);
    }
}

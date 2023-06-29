using Microsoft.EntityFrameworkCore;

namespace EF;

public class AppContext : DbContext
{
    // Объекты таблицы Users
    public DbSet<User> Users { get; set; }

    // Объекты таблицы Books
    public DbSet<Book> Books { get; set; }

    // Объекты таблицы Genres
    public DbSet<Genre> Genres { get; set; }

    // Объекты таблицы Authors
    public DbSet<Author> Authors { get; set; }


    public AppContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-B5LD0OU;Server=.\SQLEXPRESS;Database=EF;Trusted_Connection=True;Trust Server Certificate=true;");
    }
}
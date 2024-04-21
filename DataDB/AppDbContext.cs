using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject.DataDB
{
    /// <summary>
    /// Kontekst bazy danych aplikacji.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Konstruktor kontekstu bazy danych aplikacji.
        /// </summary>
        /// <param name="options">Opcje kontekstu bazy danych.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet dla dostępu do tabel w bazie danych

        /// <summary>
        /// Zbiór danych użytkowników.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Zbiór danych artykułów.
        /// </summary>
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Article>().ToTable("articles");
        }
    }
}

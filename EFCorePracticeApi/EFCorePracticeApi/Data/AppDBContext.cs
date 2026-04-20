using Microsoft.EntityFrameworkCore;

namespace EFCorePracticeApi.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Currencies>().HasData(
                new Currencies { Id = 1, Title = "USD", Description = "United States Dollar" },
                new Currencies { Id = 2, Title = "EUR", Description = "Euro" },
                new Currencies { Id = 3, Title = "JPY", Description = "Japanese Yen" },
                new Currencies { Id = 4, Title = "INR", Description = "Indian Rupee" }
            );

             modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Title = "Hindi", Description="Hindi Language" },
                new Language { Id = 2, Title = "Tamil", Description="Tamil Language" },
                new Language { Id = 3, Title = "Punjabi", Description="Punjabi Language" },
                new Language { Id = 4, Title = "Marathi", Description="Marathi Language" }
            );
        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Currencies> Currencies { get; set; }

        public DbSet<BookPrice> BookPrices { get; set; }

    }
}

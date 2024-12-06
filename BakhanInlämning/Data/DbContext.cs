using Models;
using Microsoft.EntityFrameworkCore;

public class DbContextUppgift : DbContext
{
    
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Loan> Loans { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Library;Trusted_Connection=True;");
        }
}
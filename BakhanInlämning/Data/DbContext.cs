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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasMany(p=> p.BookAuthors)
                .WithOne(a => a.Book)
                .HasForeignKey(p => p.BookId);

            modelBuilder.Entity<Author>()
                .HasMany(p=> p.BookAuthors)
                .WithOne(a => a.Author)
                .HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<Loan>()
                .HasMany(p=> p.Books)
                .WithOne(a => a.Loan)
                .HasForeignKey(p => p.Loanid);
    }
}
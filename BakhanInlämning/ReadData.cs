using Microsoft.EntityFrameworkCore;
using Models;

public class ReadData
{
    public static void Run()
    {
        using (var context = new DbContextUppgift())
        {
            var books = context.Books
                .Include(p => p.BookAuthors)
                .ToList();


            if (books.Any())
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"Title: {book.Title}, Year: {book.Year}");
                    foreach (var bookAuthor in book.BookAuthors)
                    {
                        Console.WriteLine($"Author: {bookAuthor.Author}");
                    }
                }

                Console.WriteLine("Books on loan");

                var loans = context.Loans.ToList();

                foreach (var loan in loans)
                {
                    Console.WriteLine($"Book: {loan.Book} is on loan until: {loan.date}");
                }
            }
            else
            {
                Console.WriteLine("Inga böcker hittades i databasen.");
            }
        }
    }
}

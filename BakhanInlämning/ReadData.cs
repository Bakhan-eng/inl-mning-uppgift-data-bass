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
                    foreach(var bookAuthor in book.BookAuthors){
                        Console.WriteLine($"Author: {bookAuthor.Author}");
                    }
                }

                Console.WriteLine("Books on loan");

                foreach(var book in books){
                    if(book.Loan != null){
                        Console.WriteLine($"Book: {book} is on loan until: {book.Loan.date}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Inga böcker hittades i databasen.");
            }
        }
    }
}

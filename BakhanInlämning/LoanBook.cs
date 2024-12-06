using Microsoft.EntityFrameworkCore;

using Models;
public class LoanBook
{
    public static void Run()
    {

        using (var context = new DbContextUppgift())
        {
            Console.WriteLine("Enter name of book to check out");
            var input = Console.ReadLine();

            var loans = context.Loans.ToList();

            if (loans.Any())
            {
                foreach (var loan in loans)
                {
                    if (loan.Book != null && loan.Book.Title == input)
                    {
                        Console.WriteLine("Book is already loaned out");
                        return;
                    }
                }
            }
            var books = context.Books.ToList();
            foreach (var book in books)
            {
                if (book.Title == input)
                {
                    var loan = new Loan
                    {
                        Book = book,
                        date = DateTime.Today.AddDays(7)
                    };
                }
            }
        }
    }
}
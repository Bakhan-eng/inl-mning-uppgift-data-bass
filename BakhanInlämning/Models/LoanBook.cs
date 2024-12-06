using Microsoft.EntityFrameworkCore;

using Models;
public class LoanBook{
    public static void Run(){
        
        using (var context = new DbContextUppgift())
        {
            Console.WriteLine("Enter name of book to check out");
            var input = Console.ReadLine();
            
            var books = context.Books
                .Include(p => p.Loan)
                .ToList();

            if (books.Any())
            {
                foreach(var book in books){
                    if(book.Title == input){
                        if(book.Loan != null){
                            book.Loan.Books.Add(book);
                            book.Loan.date = DateTime.Today.AddDays(7);
                        }
                        else{
                            Console.WriteLine("Book is already loaned out");
                        }
                    }
                }
            }
        }   
    }
}
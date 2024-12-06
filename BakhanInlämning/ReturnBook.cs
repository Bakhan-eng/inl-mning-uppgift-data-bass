using Microsoft.EntityFrameworkCore;

public class ReturnBook{
    public static void Run(){
        using (var context = new DbContextUppgift())
        {
            Console.WriteLine("Enter name of book to return");
            var input = Console.ReadLine();

            var loans = context.Loans
                    .Include(p => p.Books)
                    .ToList();
                    
            foreach(var loan in loans){
                foreach(var book in loan.Books){
                    if(input == book.Title){
                        book.Loan = null;
                        loan.Books.Remove(book);
                        if(loan.Books.Count == 0 ){
                            loans.Remove(loan);
                        }
                        break;
                    }
                } 
            }
        }
    }
}
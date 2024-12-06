using Microsoft.EntityFrameworkCore;

public class ReturnBook
{
    public static void Run()
    {
        using (var context = new DbContextUppgift())
        {
            Console.WriteLine("Enter name of book to return");
            var input = Console.ReadLine();

            var loans = context.Loans
                    .Include(p => p.Book)
                    .ToList();

            foreach (var loan in loans)
            {
                if (input == loan.Book.Title)
                {
                    context.Remove(loan);
                    break;
                }
            }
        }
    }
}
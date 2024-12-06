using Microsoft.EntityFrameworkCore;
public class RemoveBook{
    public static void Run(){
        
        using (var context = new DbContextUppgift())
        {
        System.Console.WriteLine("Enter book to remove");
        var input = Console.ReadLine();

        var books = context.Books.ToList();

        foreach(var book in books){
            if(book.Title == input){
                context.Remove(book.BookAuthors);
                context.Remove(book);
                break;
            }
        }
        }
    }
}
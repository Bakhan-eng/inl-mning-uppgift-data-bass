using Models;
public class AddData
{
    public static void Run()
    {
        using (var context = new DbContextUppgift())
        {
            var book = new Book
            {
                Title = "Title one",
                Year = 1970
            };

            var author = new Author{
                Name = "AuthorName one"
            };

            var bookAuthor = new BookAuthor{
                Book = book,
                Author = author
            };

            book.BookAuthors.Add(bookAuthor);
            author.BookAuthors.Add(bookAuthor);

            context.Books.Add(book);
            context.Authors.Add(author);
            context.BookAuthors.Add(bookAuthor);

            context.SaveChanges();

            Console.WriteLine("Data har sparats i databasen.");
        }
    }
}

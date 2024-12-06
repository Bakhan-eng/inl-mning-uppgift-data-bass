using Models;
public class Seed
{
    public static void Run()
    {
        using (var context = new DbContextUppgift())
        {
            context.Database.EnsureCreated();

            var book = new Book
            {
                Title = "Book 1",
                Year = 1900
            };

            var author = new Author
            {
                Name = "author one"
            };

            context.Books.Add(book);
            context.Authors.Add(author);

            var bookAuthor = new BookAuthor
            {
                Book = book,
                Author = author
            };

            context.BookAuthors.Add(bookAuthor);


            book.BookAuthors.Add(bookAuthor);
            author.BookAuthors.Add(bookAuthor);


            book = new Book
            {
                Title = "Book 2",
                Year = 1990
            };

            author = new Author
            {
                Name = "author two"
            };

            context.Books.Add(book);
            context.Authors.Add(author);

            bookAuthor = new BookAuthor
            {
                Book = book,
                Author = author
            };

            context.BookAuthors.Add(bookAuthor);


            book.BookAuthors.Add(bookAuthor);
            author.BookAuthors.Add(bookAuthor);

            book = new Book
            {
                Title = "Book 3",
                Year = 1900
            };

            author = new Author
            {
                Name = "author three"
            };


            context.Books.Add(book);
            context.Authors.Add(author);


            bookAuthor = new BookAuthor
            {
                Book = book,
                Author = author
            };

            context.BookAuthors.Add(bookAuthor);

            book.BookAuthors.Add(bookAuthor);
            author.BookAuthors.Add(bookAuthor);

            context.SaveChanges();

            Console.WriteLine("Data har sparats i databasen.");
        }
    }
}

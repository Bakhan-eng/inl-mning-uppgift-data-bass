using Models;
public class AddData
{
    public static void Run()
    {
        using (var context = new DbContextUppgift())
        {
            context.Database.EnsureCreated();

            Console.WriteLine("Enter title of book to add");
            var title = Console.ReadLine();

            Console.WriteLine("Enter year of publish for the book");
            var year = int.Parse(Console.ReadLine());

            var book = new Book
            {
                Title = title,
                Year = year,
                Loan = null
            };

            context.Books.Add(book);


            Console.WriteLine("Enter the authors of the book like so: Author1;author2;...");
            var authors = Console.ReadLine().Split(';');
            

            for(int i = 0; i < authors.Length; i++){
                var author = new Author{
                    Name = authors[i]
                };

                context.Authors.Add(author);

                var bookAuthor = new BookAuthor{
                    Book = book,
                    Author = author
                };

                context.BookAuthors.Add(bookAuthor);
                
                book.BookAuthors.Add(bookAuthor);
                author.BookAuthors.Add(bookAuthor);
            }
            
            context.SaveChanges();

            Console.WriteLine("Data har sparats i databasen.");
        }
    }
}

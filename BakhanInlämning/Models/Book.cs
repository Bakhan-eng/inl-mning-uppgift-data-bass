namespace Models{
    public class Book{
        public int Id { get; set; }
        public string Title {get; set; }
        public int Year {get; set; }
        public ICollection<BookAuthor> BookAuthors {get; set;}

        public int Loanid {get; set;}
        public Loan Loan {get; set;}
    } 
}
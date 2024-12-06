namespace Models{
    public class Loan{
        public int Id {get; set;}
        public DateTime date {get; set;}
        public ICollection<Book> Books {get; set;}
    }
}
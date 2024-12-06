namespace Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime date { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
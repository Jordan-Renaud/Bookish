namespace Bookish
{
    public class BookBag
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<Copy> BookCopies { get; set; }
    }
}
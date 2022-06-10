namespace Bookish
{
    public class BookBag
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public List<Copy> BookCopies { get; set; }
    }
}
namespace Bookish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public string FictionVsNonFiction { get; set; }
        public Genre Genre { get; set; }
    }
}
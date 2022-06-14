namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string Title { get; set; }
        public List<int> AuthorIds { get; set; }
        public string FictionVsNonFiction { get; set; }
        public int GenreId { get; set; }
    }
}
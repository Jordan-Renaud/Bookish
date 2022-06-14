namespace Bookish.Models.Requests
{
    public class CreateBookRequest
    {
        public string Title { get; set; }
        public int AuthorId {get; set;}
        public string FictionVsNonFiction { get; set; }
        public int GenreId {get; set;}
    }
}
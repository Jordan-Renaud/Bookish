namespace Bookish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string FictionVsNonFiction { get; set; }
        public int GenreId { get; set; }
        public string CoverUrl { get; set; }
        public string Blurb { get; set; }
        public string Author { get; set; }

        // public Book(int id, string title, int authorId, string fictionVsNonFiction, int genreId)
        // {
        //     Id = id;
        //     Title = title;
        //     AuthorId = authorId;
        //     FictionVsNonFiction = fictionVsNonFiction;
        //     GenreId = genreId;
        // }
    }
}
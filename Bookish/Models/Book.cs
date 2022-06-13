namespace Bookish
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public string FictionVsNonFiction { get; set; }
        public Genre Genre { get; set; }


        public string GetAllAuthors()
        {
            string formattedAuthors = "";

            for (int i = 0; i <= Authors.Count - 1; i++)
            {
                if (i == Authors.Count - 1)
                {
                    formattedAuthors += Authors[i].Name + ".";
                }
                else
                {
                    formattedAuthors += Authors[i].Name + ", ";
                }
            }

            return formattedAuthors;
        }
    }
}
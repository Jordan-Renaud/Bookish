using Microsoft.EntityFrameworkCore;

//Repositories

//Just does stuff with the database.
//Nothing should access your repo, except your service.

namespace Bookish.Repositories
{
    public class BookRepo
    {
        //gets the database, creates an instance of it.
        private BookishContext _context = new BookishContext();

        public Book GetBookById(int id)
        {
            return _context
                    .Books
                    .Where(book => book.Id == id)
                    .Include(book => book.Authors)
                    .Include(book => book.Genre)
                    .Single();
        }

        public List<Book> GetAllBooks()
        {
            return _context
                .Books
                .Include(book => book.Authors)
                .Include(book => book.Genre)
                .ToList();
        }
    }
}
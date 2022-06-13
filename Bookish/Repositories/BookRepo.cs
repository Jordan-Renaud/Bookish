using Microsoft.EntityFrameworkCore;

namespace Bookish.Repositories
{
    public class BookRepo
    {
        private BookishContext _context = new BookishContext();

        public Book GetBookById(int id)
        {
            return _context
                    .Books
                    .Where(book => book.Id == id)
                    .Include(book => book.Authors)
                    .Single();
        }

        public List<Book> GetAllBooks()
        {
            return _context
                .Books
                .Include(book => book.Authors)
                .ToList();
        }
    }
}
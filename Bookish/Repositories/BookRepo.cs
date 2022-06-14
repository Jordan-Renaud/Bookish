using Microsoft.EntityFrameworkCore;
using Bookish.Models.Requests;

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
        public Book CreateBook(CreateBookRequest request)
        {
            Book newBook = new Book
            {
                Title = request.Title,
            };

            Genre genre = _context
            .Genres
            .Where(g => g.Id == request.GenreId)
            .Single();

            List<Author> authors = new List<Author>();

            foreach (var authorId in request.AuthorIds)
            {
                Author author = _context
                .Authors
                .Where(a => a.Id == authorId)
                .Single();

                authors.Add(author);
            }

            newBook.Authors = authors;
            newBook.Genre = genre;

            return newBook;
        }

    }
}
using Bookish.Repositories;

//Services

//could talk to mutiple repos
//does stuff no strictly related to the database
//      - access an external service related to the books.

namespace Bookish.Services
{
    public class BookService
    {
        private BookRepo _bookRepo = new BookRepo();

        public Book GetBookById(int id)
        {
            return _bookRepo.GetBookById(id);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepo.GetAllBooks();
        }
    }
}
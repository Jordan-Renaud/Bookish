using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private BookService _bookService;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
        _bookService = new BookService();
    }

    public IActionResult Index()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10);
        Book book = _bookService.GetBookById(randomNumber);

        return View(book);
    }
    public IActionResult BookListIndex()
    {
        List<Book> BookList = _bookService.GetAllBooks();

        return View(BookList);
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;
using Bookish.Models.Requests;

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

    [HttpGet]
    public IActionResult Index()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 10);
        Book book = _bookService.GetBookById(randomNumber);

        return View(book);
    }

    [HttpGet]
    public IActionResult BookList()
    {
        List<Book> books = _bookService.GetAllBooks();

        return View("BookList", books);
    }

    [HttpGet("/Book/Create")]
    public IActionResult CreateBookForm()
    {

        return View("CreateBook");
    }

    [HttpPost("/")]
    public IActionResult CreateBook([FromBody] CreateBookRequest request)
    {
        Book book = _bookService.CreateNewBook(request);

        return View("Book", book);
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Book book = new Book
        {
            Id = 1,
            Title = "Anything You Can Write!",
            AuthorId = 1,
            FictionVsNonFiction = "NonFiction",
            GenreId = 1
        };
        return View(book);
    }
}

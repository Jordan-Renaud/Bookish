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
            GenreId = 1,
            CoverUrl = "https://www.trainingzone.co.uk/sites/default/files/elenaleonova-books.jpg",
            Blurb = @"As one of history’s greatest literary figures, Ernest Hemingway, once explained, “there is no friend as loyal as a book”.In a world where many of us are now glued to screens from sunrise to sunset, the importance of these words can easily be overlooked. Our multimodal world has many advantages – speed, ease, connectedness, access to information and much more.One of the downsides, however, is that the humble book has taken a backseat. Books are often seen as a pastime – a hobby – something we try to make time for, but often find ourselves unable to do with the distractions of modern technology.",
            Author = "Stephen Hawking",
        };
        return View(book);
    }
}

using BookShopCodeFirst.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookShopCodeFirst.Controllers;



[ApiController]
[Route("/api/[controller]")]
public class BookController : ControllerBase
{

    private readonly BooksContext _context;

    public BookController(BooksContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> getAllAuthors()
    {
        var x = _context.Authors
            .Select(e => new
            {
                FirstName = e.FirstName
            }).Where(e => e.FirstName.StartsWith("J")).ToList();

        return Ok(x);

    }

}
using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
  private readonly BookContext _context;

  public BooksController(BookContext context)
  {
    _context = context;
  }

  // GET: api/books
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
  {
    return await _context.Books.ToListAsync();
  }

  // GET: api/books/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Book>> GetBook(int id)
  {
    var book = await _context.Books.FindAsync(id);

    if (book == null)
    {
      return NotFound();
    }

    return book;
  }

  // POST api/books
  [HttpPost]
  public async Task<ActionResult<Book>> PostBook(Book book)
  {
    _context.Books.Add(book);
    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
  }

  // PUT api/books/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutBook(int id, Book book)
  {
    if (id != book.Id)
    {
      return BadRequest();
    }

    _context.Entry(book).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // DELETE api/books/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteBook(int id)
  {
    var book = await _context.Books.FindAsync(id);

    if (book == null)
    {
      return NotFound();
    }

    _context.Books.Remove(book);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  // dummy endpoint to test the database connection
  [HttpGet("test")]
  public string Test()
  {
    return "Hello World!";
  }
}
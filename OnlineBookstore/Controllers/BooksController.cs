using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Data.Repositories;
using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult> AddBook(Book book)
        {
            await _bookRepository.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.BookID }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book book)
        {
            if (id != book.BookID)
            {
                return BadRequest();
            }

            await _bookRepository.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _bookRepository.DeleteBook(id);
            return NoContent();
        }
    }
}

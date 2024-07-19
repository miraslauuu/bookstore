using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBookstore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly OnlineBookstoreContext _context;

        public BookRepository(OnlineBookstoreContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> GetBookById(int bookId)
        {
            return await _context.Books.FindAsync(bookId);
        }

        public async Task AddBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBook(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBook(int bookId)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}

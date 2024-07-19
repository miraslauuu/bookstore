using OnlineBookstore.Models;
using OnlineBookstore.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _bookRepository.GetAllBooks();
        }

        public async Task<Book> GetBookById(int bookId)
        {
            return await _bookRepository.GetBookById(bookId);
        }

        public async Task AddBook(Book book)
        {
            await _bookRepository.AddBook(book);
        }

        public async Task UpdateBook(Book book)
        {
            await _bookRepository.UpdateBook(book);
        }

        public async Task DeleteBook(int bookId)
        {
            await _bookRepository.DeleteBook(bookId);
        }
    }
}

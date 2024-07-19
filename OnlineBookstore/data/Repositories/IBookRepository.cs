using OnlineBookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineBookstore.Data.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int bookId);
        Task AddBook(Book book);
        Task UpdateBook(Book book);
        Task DeleteBook(int bookId);
    }
}

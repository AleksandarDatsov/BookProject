using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<IEnumerable<Book>> GetBooksAsync(ISpecification<Book> bookSpecification);
    }
}

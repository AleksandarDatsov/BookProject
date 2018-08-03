using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Persistance.Specification;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistance.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(IApplicationDbContext context)
            : base(context)
        {
        }

        public async Task AddAsync(Book book)
        {
            await this.Entities.AddAsync(book);
        }

        public async Task<IEnumerable<Book>> GetBooksAsync(ISpecification<Book> specification)
        {
            return await this.Entities.Where(specification.ToExpression())
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Include(b => b.Subject)
                .ToListAsync();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistance.Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(IApplicationDbContext context)
            : base(context)
        {
        }

        public async Task AddAsync(Author author)
        {
            await this.Entities.AddAsync(author);
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await this.Entities.ToListAsync();
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories
{
    public interface IAuthorRepository
    {
        Task AddAsync(Author author);

        Task<List<Author>> GetAllAuthors();
    }
}

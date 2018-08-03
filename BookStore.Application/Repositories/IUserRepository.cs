using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}

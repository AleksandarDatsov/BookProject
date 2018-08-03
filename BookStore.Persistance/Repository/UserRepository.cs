using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;

namespace BookStore.Persistance.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IApplicationDbContext context)
            : base(context)
        {
        }

        async Task IUserRepository.AddAsync(User user)
        {
            await this.Entities.AddAsync(user);
        }
    }
}

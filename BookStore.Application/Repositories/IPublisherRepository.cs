using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Domain.Entities;

namespace BookStore.Application.Repositories
{
    public interface IPublisherRepository
    {
        Task AddAsync(Publisher publisher);

        Task<List<Publisher>> GetAllPublishers();
    }
}

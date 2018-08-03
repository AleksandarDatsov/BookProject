using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistance.Repository
{
    public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
    {
        public PublisherRepository(IApplicationDbContext context)
            : base(context)
        {
        }

        public async Task AddAsync(Publisher publisher)
        {
            await this.Entities.AddAsync(publisher);
        }

        public async Task<List<Publisher>> GetAllPublishers()
        {
            return await this.Entities.ToListAsync();
        }
    }
}

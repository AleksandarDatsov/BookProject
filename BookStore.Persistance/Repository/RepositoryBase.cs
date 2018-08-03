using BookStore.Application;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistance.Repository
{
    public class RepositoryBase<TEntity>
        where TEntity : class
    {
        private IApplicationDbContext context;

        public RepositoryBase(IApplicationDbContext context)
        {
            this.context = context;
        }

        public DbSet<TEntity> Entities => this.context.Set<TEntity>();
    }
}
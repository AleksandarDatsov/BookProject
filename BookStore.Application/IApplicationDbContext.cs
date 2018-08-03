using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BookStore.Application
{
    public interface IApplicationDbContext
    {
        DatabaseFacade Database { get; }

        DbSet<User> Users { get; set; }

        DbSet<Book> Books { get; set; }

        DbSet<Publisher> Publishers { get; set; }

        DbSet<Author> Authors { get; set; }

        DbSet<TEntity> Set<TEntity>()
           where TEntity : class;

        int SaveChanges();

        void Dispose();
    }
}

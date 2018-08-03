using Microsoft.EntityFrameworkCore.Storage;

namespace BookStore.Application
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        IDbContextTransaction BeginTransaction();
    }
}

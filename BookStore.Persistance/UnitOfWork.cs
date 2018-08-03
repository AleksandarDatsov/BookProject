using System;
using BookStore.Application;
using Microsoft.EntityFrameworkCore.Storage;

namespace BookStore.Persistance
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IApplicationDbContext context;

        public UnitOfWork(IApplicationDbContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return this.context.Database.BeginTransaction();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.context.Dispose();
            }
        }
    }
}

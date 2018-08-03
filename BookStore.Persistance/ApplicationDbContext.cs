using BookStore.Application;
using BookStore.Domain.Entities;
using BookStore.Domain.UserIdentity;
using BookStore.Persistance.EntitiesConfigurations;
using BookStore.Persistance.EntitiesConfigurations.IdentityUserConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Persistance
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new PublisherMap());
            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserMap());
            modelBuilder.ApplyConfiguration(new ApplicationClaimMap());
            modelBuilder.ApplyConfiguration(new ApplicationLoginMap());
            modelBuilder.ApplyConfiguration(new ApplicationRoleMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleMap());
            modelBuilder.ApplyConfiguration(new ApplicationUserTokenMap());
            modelBuilder.ApplyConfiguration(new UserSubjectMap());
        }
    }
}

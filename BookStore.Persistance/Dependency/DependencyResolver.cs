using BookStore.Application;
using BookStore.Application.Providers;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Domain.UserIdentity;
using BookStore.Persistance.Repository;
using BookStore.Persistance.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Persistance.Dependency
{
    public static class DependencyResolver
    {
        public static void SetDependencies(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IAppSettingsProvider>((s) => new AppSettingsProvider(configuration));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IPublisherRepository, PublisherRepository>();

            services.AddTransient<BookService>();
            services.AddTransient<AuthorService>();
            services.AddTransient<PublisherService>();

            services.AddIdentity<User, ApplicationRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }
    }
}

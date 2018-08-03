using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.AuthorModels;

namespace BookStore.Persistance.Services
{
    public class AuthorService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IAuthorRepository authorRepo;

        public AuthorService(IUnitOfWork unitOfWork, IAuthorRepository authorRepo)
        {
            this.unitOfWork = unitOfWork;
            this.authorRepo = authorRepo;
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            return (await this.authorRepo.GetAllAuthors()).Select(a => new AuthorDto(a)).ToList();
        }

        public async Task AddAuthor(string name)
        {
            await this.authorRepo.AddAsync(new Author()
            {
                Name = name,
            });

            this.unitOfWork.SaveChanges();
        }
    }
}

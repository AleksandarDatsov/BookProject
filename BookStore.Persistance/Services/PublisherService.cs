using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.PublisherModels;

namespace BookStore.Persistance.Services
{
    public class PublisherService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPublisherRepository publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository, IUnitOfWork unitOfWork)
        {
            this.publisherRepository = publisherRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PublisherDto>> GetAllPublishers()
        {
            var publishers = await this.publisherRepository.GetAllPublishers();
            return publishers.Select(p => new PublisherDto(p));
        }

        public async Task AddPublisher(string name)
        {
            await this.publisherRepository.AddAsync(new Publisher()
            {
                Name = name,
            });

            this.unitOfWork.SaveChanges();
        }
    }
}

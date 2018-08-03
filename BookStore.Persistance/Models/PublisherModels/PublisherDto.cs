using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.BookModels;

namespace BookStore.Persistance.Models.PublisherModels
{
    public class PublisherDto
    {
        public PublisherDto(Publisher publisher)
        {
            this.Name = publisher.Name;
            this.Books = new List<BookDto>();
        }

        public string Name { get; set; }

        public ICollection<BookDto> Books { get; set; }

        public Publisher ToPublisher()
        {
            var publisher = new Publisher();
            publisher.Name = this.Name;
            publisher.Books = this.Books.Select(b => b.ToBook()).ToList();
            return publisher;
        }
    }
}

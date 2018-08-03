using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.BookModels;

namespace BookStore.Persistance.Models.AuthorModels
{
    public class AuthorDto
    {
        public AuthorDto()
        {
        }

        public AuthorDto(Author author)
        {
            this.Name = author.Name;
            this.Books = new List<BookDto>();
        }

        public string Name { get; set; }

        public ICollection<BookDto> Books { get; set; }

        public Author ToAuthor()
        {
            var author = new Author();
            author.Name = this.Name;
            author.Books = this.Books.Select(b => b.ToBook()).ToList();
            return author;
        }
    }
}

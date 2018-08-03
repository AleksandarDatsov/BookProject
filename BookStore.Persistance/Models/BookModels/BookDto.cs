using System;
using System.Collections.Generic;
using System.Text;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.AuthorModels;
using BookStore.Persistance.Models.PublisherModels;

namespace BookStore.Persistance.Models.BookModels
{
    public class BookDto
    {
        public BookDto(Book book)
        {
            this.Title = book.Title;
            this.AuthorDto = new AuthorDto(book.Author);
            this.PublisherDto = new PublisherDto(book.Publisher);
            this.DateOfPublishing = book.DateOfPublishing;
        }

        public string Title { get; set; }

        public AuthorDto AuthorDto { get; set; }

        public PublisherDto PublisherDto { get; set; }

        public DateTime DateOfPublishing { get; set; }

        public Book ToBook()
        {
            var book = new Book();
            book.Title = this.Title;
            book.Author = this.AuthorDto.ToAuthor();
            book.Publisher = this.PublisherDto.ToPublisher();
            book.DateOfPublishing = this.DateOfPublishing;

            return book;
        }
    }
}

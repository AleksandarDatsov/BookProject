using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Persistance.Models.BookModels;
using BookStore.Persistance.Specification;

namespace BookStore.Persistance.Services
{
    public class BookService
    {
        private readonly IBookRepository bookRepo;

        public BookService(IBookRepository bookRepo)
        {
            this.bookRepo = bookRepo;
        }

        public async Task<IEnumerable<BookDto>> GetBooks(ISpecification<Book> bookSpecification)
        {
            var books = await this.bookRepo.GetBooksAsync(bookSpecification);
            return books.Select(b => new BookDto(b));
        }
    }
}

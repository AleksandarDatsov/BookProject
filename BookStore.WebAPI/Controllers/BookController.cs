using System.Threading.Tasks;
using BookStore.Application;
using BookStore.Application.Repositories;
using BookStore.Domain.Entities;
using BookStore.Persistance.Services;
using BookStore.Persistance.Specification;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService bookService;

        public BookController(BookService bookService)
        {
            this.bookService = bookService;
        }

        /// <summary>Get books depending on passed parameters</summary>
        /// <param name="author">The name of the desired author. By default is null.</param>
        /// <param name="publisher">The name of the desired publisher. By default is null.</param>
        /// <param name="title">The name of the desired title. By default is null.</param>
        /// <returns>List of Books</returns>
        [HttpGet]
        [Route("by-specification")]
        public async Task<IActionResult> Get(string author = null, string publisher = null, string title = null)
        {
            var bookSpecification = new AuthorSpecification(author)
                .And(new PublisherSpecificaiton(publisher))
                .And(new TitleSpecification(title));

            return this.Ok(await this.bookService.GetBooks(bookSpecification));
        }
    }
}

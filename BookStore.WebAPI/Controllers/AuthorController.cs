using System.Threading.Tasks;
using BookStore.Persistance.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers
{
    [Route("api/author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService authorService;

        public AuthorController(AuthorService authorService)
        {
            this.authorService = authorService;
        }

        /// <summary>
        /// Get all Authors from database
        /// </summary>
        /// <returns>List of Authors</returns>
        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAllAuthors()
        {
            return this.Ok(await this.authorService.GetAllAuthors());
        }

        /// <summary>
        /// Operation for adding new author to database
        /// </summary>
        /// <param name="name">The name of the desired Author</param>
        /// <returns>Status 200 if everything is Ok</returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddAuthor(string name)
        {
            await this.authorService.AddAuthor(name);
            return this.Ok();
        }
    }
}
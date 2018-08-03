using System.Threading.Tasks;
using BookStore.Persistance.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebAPI.Controllers
{
    [Route("api/publisher")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly PublisherService publisherService;

        public PublisherController(PublisherService publisherService)
        {
            this.publisherService = publisherService;
        }

        /// <summary>
        /// Get all publishers from database
        /// </summary>
        /// <returns>List of Publishers</returns>
        [HttpGet]
        [Route("get-all")]
        public async Task<IActionResult> GetAllPublishers()
        {
            return this.Ok(await this.publisherService.GetAllPublishers());
        }

        /// <summary>
        /// Operation for adding new publisher to database
        /// </summary>
        /// <param name="name">The name of the desired Publisher</param>
        /// <returns>Status 200 if everything is Ok</returns>
        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddPublisher(string name)
        {
            await this.publisherService.AddPublisher(name);
            return this.Ok();
        }
    }
}
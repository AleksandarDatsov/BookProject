using Common;
using Microsoft.Extensions.Configuration;

namespace BookStore.Application.Providers
{
    public class AppSettingsProvider : IAppSettingsProvider
    {
        private readonly IConfiguration configuration;

        public AppSettingsProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetDataBaseConnectionString => this.configuration.GetConnectionString(Constants.BookStoreDBConnectionString);
    }
}

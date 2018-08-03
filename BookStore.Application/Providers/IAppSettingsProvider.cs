namespace BookStore.Application.Providers
{
    public interface IAppSettingsProvider
    {
        string GetDataBaseConnectionString { get; }
    }
}

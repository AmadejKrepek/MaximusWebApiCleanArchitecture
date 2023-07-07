namespace Application.Repositories
{
    public interface ICallApi
    {
        void SetAuthenticationHeaderValue(string token);
        void SetTokenHeaderValue(string value);
        Task<T> GetData<T>(string url);

    }
}

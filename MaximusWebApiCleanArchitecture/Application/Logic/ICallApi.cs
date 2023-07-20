namespace Application.Logic
{
    public interface ICallApi
    {
        void SetAuthenticationHeaderValue(string token);
        void SetTokenHeaderValue(string value);
        Task<T> GetData<T>(string query);
        Task<T> PostData<T>(string query, T data);
        Task<T> PutData<T>(string query, T data);
        Task DeleteData<T>(string query);

    }
}

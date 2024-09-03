using System.Net.Http.Json;
using Domain;

namespace LibraryTaskFront.Services
{
    public class LibraryServices
    {
        private readonly HttpClient _httpClient;

        public LibraryServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Book>>("https://localhost:7007/api/Books");
        }

        public async Task<HttpResponseMessage> AddBookAsync(Book book)
        {
            return await _httpClient.PostAsJsonAsync("https://localhost:7007/api/Books", book);
        }


        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Book>($"https://localhost:7007/api/Books/{id}");
        }

        public async Task<HttpResponseMessage> UpdateBookAsync(Book book)
        {
            return await _httpClient.PutAsJsonAsync($"https://localhost:7007/api/Books/{book.Id}", book);
        }

        public async Task<HttpResponseMessage> DeleteBookAsync(int id)
        {
            return await _httpClient.DeleteAsync($"https://localhost:7007/api/Books/{id}");
        }
    }
}

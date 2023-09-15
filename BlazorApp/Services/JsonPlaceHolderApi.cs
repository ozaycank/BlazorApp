using System.Net.Http.Json;
using BlazorApp.Models;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class JsonPlaceHolderApi : IApiService
    {
        private readonly HttpClient _http;

        public JsonPlaceHolderApi(HttpClient http)
        {
            _http = http;
        }

        public async Task<TodoItem[]> GetTodos()
        {
            var result = await _http.GetFromJsonAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos");
            return result ?? new TodoItem[0];
        }
    }
}

using BlazorApp.Models;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public interface IApiService
    {
        Task<TodoItem[]> GetTodos();
    }
}

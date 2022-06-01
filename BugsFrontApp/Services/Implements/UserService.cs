using BugsWebAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BugsFrontApp.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserModel>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<List<UserModel>>("api/Users");
        }
    }
}

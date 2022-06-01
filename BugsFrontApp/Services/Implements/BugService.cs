using BugsWebAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BugsFrontApp.Services.Implements
{
    public class BugService : IBugService
    {
        private readonly HttpClient _httpClient;

        public BugService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<BugModel>> GetBugs()
        {
            return await _httpClient.GetFromJsonAsync<List<BugModel>>("api/Bugs");
        }
    }
}

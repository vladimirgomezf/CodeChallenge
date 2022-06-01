using BugsWebAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BugsFrontApp.Services.Implements
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;

        public ProjectService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProjectModel>> GetProjects()
        {
            return await _httpClient.GetFromJsonAsync<List<ProjectModel>>("api/Projects");
        }
    }
}

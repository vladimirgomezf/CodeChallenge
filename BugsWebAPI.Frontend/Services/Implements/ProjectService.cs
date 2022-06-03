using BugsWebAPI.Fontend.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BugsWebAPI.Fontend.Services.Implements
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
            try
            {
                return await _httpClient.GetFromJsonAsync<List<ProjectModel>>("api/Projects");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}

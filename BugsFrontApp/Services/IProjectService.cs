using BugsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugsFrontApp.Services
{
    public interface IProjectService
    {
        Task<List<ProjectModel>> GetProjects();
    }
}

using BugsWebAPI.Fontend.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugsWebAPI.Fontend.Services
{
    public interface IBugService
    {
        Task<List<BugModel>> GetBugs();
    }
}

using BugsWebAPI.Data;
using BugsWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BugsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly BugsContext _context;

        public ProjectsController(BugsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProjectModel>>> Get()
        {
            return Ok(await _context.ProjectModels.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectModel>> Get(int id)
        {
            var project = await _context.ProjectModels.FindAsync(id);
            if (project == null)
            {
                return BadRequest("Student Not found!");
            }
            return Ok(project);
        }

        [HttpPost]
        public async Task<ActionResult<List<ProjectModel>>> Post([FromBody] ProjectModel project)
        {
            _context.ProjectModels.Add(project);
            await _context.SaveChangesAsync();

            return Ok(_context.ProjectModels.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<ProjectModel>>> Put(int id, [FromBody] ProjectModel project)
        {
            var dbProject = await _context.ProjectModels.FindAsync(id);
            if (dbProject == null)
                return BadRequest("Project not found!");

            dbProject.Name = project.Name;
            dbProject.Description = project.Description;

            await _context.SaveChangesAsync();

            return Ok(await _context.ProjectModels.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProjectModel>>> Delete(int id)
        {
            var dbProject = await _context.ProjectModels.FindAsync(id);
            if (dbProject == null)
                return BadRequest("Project not found!");

            _context.ProjectModels.Remove(dbProject);
            await _context.SaveChangesAsync();

            return Ok(await _context.ProjectModels.ToListAsync());
        }
    }
}

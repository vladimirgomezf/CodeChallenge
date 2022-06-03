using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BugsWebAPI.Data;
using BugsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using BugsWebAPI.DTOs;

namespace BugsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        private readonly BugsContext _context;
        private static DateTime _ahora = DateTime.UtcNow;

        public BugsController(BugsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<BugModel>> GetBugs(int? projectId, int? userId, DateTime? startDate, DateTime? endDate)
        {
            var bugs = await _context.BugModels.ToListAsync();
            if (userId != null)
            {
                bugs = bugs.FindAll(b => b.User.Id == userId);

            }
            if (projectId != null)
            {
                bugs = bugs.FindAll(b => b.ProjectId == projectId);
            }
            if (startDate != null)
            {
                bugs = bugs.FindAll(b => b.CreationDate >= startDate);
            }
            if (endDate != null)
            {
                bugs = bugs.FindAll(b => b.CreationDate <= endDate);
            }

            return Ok(bugs);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<BugModel>> Get(int id = 1)
        {
            var bug = await _context.BugModels.FindAsync(id);
            if (bug == null)
            {
                return BadRequest("Bug Not found!");
            }
            return Ok(bug);
        }

        [HttpPost]
        public async Task<ActionResult<List<BugModel>>> Post([FromBody] BugModel bug)
        {
            _context.BugModels.Add(bug);
            await _context.SaveChangesAsync();

            return Ok(_context.BugModels.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<BugModel>>> Put(int id, [FromBody] BugModel bug)
        {
            var dbBug = await _context.BugModels.FindAsync(id);
            if (dbBug == null)
                return BadRequest("Bug not found!");

            dbBug.ProjectId = bug.ProjectId;
            dbBug.User = bug.User;
            dbBug.Description = bug.Description;
            dbBug.CreationDate = bug.CreationDate;

            await _context.SaveChangesAsync();

            return Ok(await _context.BugModels.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<BugModel>>> Delete(int id)
        {
            var dbBug = await _context.BugModels.FindAsync(id);
            if (dbBug == null)
                return BadRequest("Bug not found!");

            _context.BugModels.Remove(dbBug);
            await _context.SaveChangesAsync();

            return Ok(await _context.BugModels.ToListAsync());
        }
    }
}

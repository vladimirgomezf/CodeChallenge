using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BugsWebAPI.Data;
using BugsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BugsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly BugsContext _context;

        public UsersController(BugsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> Get()
        {
            return Ok(await _context.UserModels.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(int id)
        {
            var user = await _context.UserModels.FindAsync(id);
            if (user == null)
            {
                return BadRequest("User Not found!");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<UserModel>>> Post([FromBody] UserModel user)
        {
            _context.UserModels.Add(user);
            await _context.SaveChangesAsync();

            return Ok(_context.UserModels.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<UserModel>>> Put(int id, [FromBody] UserModel user)
        {
            var dbUser = await _context.UserModels.FindAsync(id);
            if (dbUser == null)
                return BadRequest("User not found!");

            dbUser.Name = user.Name;
            dbUser.Surname = user.Surname;

            await _context.SaveChangesAsync();

            return Ok(await _context.UserModels.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<UserModel>>> Delete(int id)
        {
            var dbUser = await _context.UserModels.FindAsync(id);
            if (dbUser == null)
                return BadRequest("User not found!");

            _context.UserModels.Remove(dbUser);
            await _context.SaveChangesAsync();

            return Ok(await _context.UserModels.ToListAsync());
        }
    }
}

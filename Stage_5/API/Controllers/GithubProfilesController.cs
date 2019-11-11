using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubProfilesController : ControllerBase
    {
        private readonly MonitoringContext _context;

        public GithubProfilesController(MonitoringContext context)
        {
            _context = context;
        }

        private readonly ILogger _logger;

        public GithubProfilesController(ILogger logger)
        {
            _logger = logger;
        }

        // GET: api/GithubProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GithubProfile>>> GetGithubProfile()
        {
            _logger.LogInformation("Created Nlog!!!");
            return await _context.GithubProfile.ToListAsync();
        }

        // GET: api/GithubProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GithubProfile>> GetGithubProfile(int id)
        {
            var githubProfile = await _context.GithubProfile.FindAsync(id);

            if (githubProfile == null)
            {
                return NotFound();
            }

            return githubProfile;
        }

        // PUT: api/GithubProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGithubProfile(int id, GithubProfile githubProfile)
        {
            if (id != githubProfile.Id)
            {
                return BadRequest();
            }

            _context.Entry(githubProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GithubProfileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GithubProfiles
        [HttpPost]
        public async Task<ActionResult<GithubProfile>> PostGithubProfile(GithubProfile githubProfile)
        {
            _context.GithubProfile.Add(githubProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGithubProfile", new { id = githubProfile.Id }, githubProfile);
        }

        // DELETE: api/GithubProfiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GithubProfile>> DeleteGithubProfile(int id)
        {
            var githubProfile = await _context.GithubProfile.FindAsync(id);
            if (githubProfile == null)
            {
                return NotFound();
            }

            _context.GithubProfile.Remove(githubProfile);
            await _context.SaveChangesAsync();

            return githubProfile;
        }

        private bool GithubProfileExists(int id)
        {
            return _context.GithubProfile.Any(e => e.Id == id);
        }
    }
}

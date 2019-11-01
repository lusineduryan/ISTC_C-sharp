using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkedinProfilesController : ControllerBase
    {
        private readonly MonitoringContext _context;

        public LinkedinProfilesController(MonitoringContext context)
        {
            _context = context;
        }

        // GET: api/LinkedinProfiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LinkedinProfile>>> GetLinkedinProfile()
        {
            return await _context.LinkedinProfile.ToListAsync();
        }

        // GET: api/LinkedinProfiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LinkedinProfile>> GetLinkedinProfile(int id)
        {
            var linkedinProfile = await _context.LinkedinProfile.FindAsync(id);

            if (linkedinProfile == null)
            {
                return NotFound();
            }

            return linkedinProfile;
        }

        // PUT: api/LinkedinProfiles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLinkedinProfile(int id, LinkedinProfile linkedinProfile)
        {
            if (id != linkedinProfile.Id)
            {
                return BadRequest();
            }

            _context.Entry(linkedinProfile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LinkedinProfileExists(id))
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

        // POST: api/LinkedinProfiles
        [HttpPost]
        public async Task<ActionResult<LinkedinProfile>> PostLinkedinProfile(LinkedinProfile linkedinProfile)
        {
            _context.LinkedinProfile.Add(linkedinProfile);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLinkedinProfile", new { id = linkedinProfile.Id }, linkedinProfile);
        }

        // DELETE: api/LinkedinProfiles/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LinkedinProfile>> DeleteLinkedinProfile(int id)
        {
            var linkedinProfile = await _context.LinkedinProfile.FindAsync(id);
            if (linkedinProfile == null)
            {
                return NotFound();
            }

            _context.LinkedinProfile.Remove(linkedinProfile);
            await _context.SaveChangesAsync();

            return linkedinProfile;
        }

        private bool LinkedinProfileExists(int id)
        {
            return _context.LinkedinProfile.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Data;
using EventManagementSystem.Models;

namespace EventManagementSystem.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Registration
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistrationModel>>> GetRegistrations()
        {
            return await _context.Registrations
                .Include(r => r.Event)
                .Include(r => r.User)
                .ToListAsync();
        }

        // GET: api/Registration/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistrationModel>> GetRegistration(int id)
        {
            var registrationModel = await _context.Registrations
                .Include(r => r.Event)
                .Include(r => r.User)
                .FirstOrDefaultAsync(r => r.RegistrationId == id);

            if (registrationModel == null)
            {
                return NotFound();
            }

            return registrationModel;
        }

        // POST: api/Registration
        [HttpPost]
        public async Task<ActionResult<RegistrationModel>> PostRegistration(RegistrationModel registrationModel)
        {
            _context.Registrations.Add(registrationModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRegistration), new { id = registrationModel.RegistrationId }, registrationModel);
        }

        // DELETE: api/Registration/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistration(int id)
        {
            var registrationModel = await _context.Registrations.FindAsync(id);
            if (registrationModel == null)
            {
                return NotFound();
            }

            _context.Registrations.Remove(registrationModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
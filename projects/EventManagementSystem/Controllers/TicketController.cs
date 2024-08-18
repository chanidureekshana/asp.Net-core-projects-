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
    public class TicketController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Ticket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketModel>>> GetTickets()
        {
            return await _context.Tickets
                .Include(t => t.Event)
                .Include(t => t.User)
                .ToListAsync();
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketModel>> GetTicket(int id)
        {
            var ticketModel = await _context.Tickets
                .Include(t => t.Event)
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.TicketId == id);

            if (ticketModel == null)
            {
                return NotFound();
            }

            return ticketModel;
        }

        // POST: api/Ticket
        [HttpPost]
        public async Task<ActionResult<TicketModel>> PostTicket(TicketModel ticketModel)
        {
            _context.Tickets.Add(ticketModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTicket), new { id = ticketModel.TicketId }, ticketModel);
        }

        // DELETE: api/Ticket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticketModel = await _context.Tickets.FindAsync(id);
            if (ticketModel == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(ticketModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}
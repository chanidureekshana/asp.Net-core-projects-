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
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context ;
        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventModel>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventModel>> GetEvent(int id)
        {
            var eventModel = await _context.Events.FindAsync(id);
            if (eventModel == null){
                return NotFound();
            }
            return eventModel;

        }

        [HttpPost]
        public async Task<ActionResult<EventModel>> PostEvent(EventModel eventModel)
        {
            _context.Events.Add(eventModel);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvent) , new {id = eventModel.EventId} , eventModel);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult>PutEvent (int id , EventModel eventModel)
        {
            if (id != eventModel.EventId){
                return NotFound();
            }
            _context.Entry(eventModel).State = EntityState.Modified;
             try 
             {
                await _context.SaveChangesAsync();
             }
             catch(DbUpdateConcurrencyException)
             {
                throw ;
             }
             return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult>DeleteEvent(int id)
        {
            var eventModel = await _context.Events.FindAsync(id);
            if (eventModel ==null){
                return NotFound();
            }
            _context.Events.Remove(eventModel);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        private bool EventModelExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }

    }
}
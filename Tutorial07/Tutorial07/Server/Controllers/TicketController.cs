using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Tutorial07.Server.Data;
using Tutorial07.Shared;

namespace Tutorial07.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase

    {
        private readonly ILogger<TicketController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public TicketController(ILogger<TicketController> logger, ApplicationDbContext applicationDbContext)

        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
        }

        // GET: api/Ticket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTicket()
        {
            return await _applicationDbContext.Ticket.ToListAsync();
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(Guid id)
        {
            var ticket = await _applicationDbContext.Ticket.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // PUT: api/Ticket/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(Guid id, Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }

            _applicationDbContext.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _applicationDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(id))
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

        // POST: api/Ticket
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTicket(Ticket ticket)
        {
            _applicationDbContext.Ticket.Add(ticket);
            await _applicationDbContext.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = ticket.Id }, ticket);
        }

        // DELETE: api/Ticket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(Guid id)
        {
            var ticket = await _applicationDbContext.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _applicationDbContext.Ticket.Remove(ticket);
            await _applicationDbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketExists(Guid id)
        {
            return _applicationDbContext.Ticket.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tutorial07.Server.Data;
using Tutorial07.Shared;

namespace Tutorial07.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignTicketController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssignTicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AssignTicket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssignTicket>>> GetAssignTicket()
        {
            return await _context.AssignTicket.ToListAsync();
        }

        // GET: api/AssignTicket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssignTicket>> GetAssignTicket(Guid id)
        {
            var assignTicket = await _context.AssignTicket.FindAsync(id);

            if (assignTicket == null)
            {
                return NotFound();
            }

            return assignTicket;
        }

        // PUT: api/AssignTicket/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignTicket(Guid id, AssignTicket assignTicket)
        {
            if (id != assignTicket.TicketID)
            {
                return BadRequest();
            }

            _context.Entry(assignTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignTicketExists(id))
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

        // POST: api/AssignTicket
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssignTicket>> PostAssignTicket(AssignTicket assignTicket)
        {
            _context.AssignTicket.Add(assignTicket);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AssignTicketExists(assignTicket.TicketID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAssignTicket", new { id = assignTicket.TicketID }, assignTicket);
        }

        // DELETE: api/AssignTicket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignTicket(Guid id)
        {
            var assignTicket = await _context.AssignTicket.FindAsync(id);
            if (assignTicket == null)
            {
                return NotFound();
            }

            _context.AssignTicket.Remove(assignTicket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssignTicketExists(Guid id)
        {
            return _context.AssignTicket.Any(e => e.TicketID == id);
        }
    }
}

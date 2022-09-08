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
    public class AssignCompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssignCompanyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AssignCompany
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssignCompany>>> GetAssignCompany()
        {
            return await _context.AssignCompany.ToListAsync();
        }

        // GET: api/AssignCompany/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssignCompany>> GetAssignCompany(Guid id)
        {
            var assignCompany = await _context.AssignCompany.FindAsync(id);

            if (assignCompany == null)
            {
                return NotFound();
            }

            return assignCompany;
        }

        // PUT: api/AssignCompany/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignCompany(Guid id, AssignCompany assignCompany)
        {
            if (id != assignCompany.ProjectID)
            {
                return BadRequest();
            }

            _context.Entry(assignCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignCompanyExists(id))
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

        // POST: api/AssignCompany
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssignCompany>> PostAssignCompany(AssignCompany assignCompany)
        {
            _context.AssignCompany.Add(assignCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssignCompany", new { id = assignCompany.ProjectID }, assignCompany);
        }

        // DELETE: api/AssignCompany/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignCompany(Guid id)
        {
            var assignCompany = await _context.AssignCompany.FindAsync(id);
            if (assignCompany == null)
            {
                return NotFound();
            }

            _context.AssignCompany.Remove(assignCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssignCompanyExists(Guid id)
        {
            return _context.AssignCompany.Any(e => e.ProjectID == id);
        }
    }
}

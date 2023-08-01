using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockBankApi.Models;
using MockBankApi.Services;

namespace MockBankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
       // private readonly StagingDbContext _context;
        private readonly IAccountService _accounts;

        public AccountsController(IAccountService accounts)
        {
         //   _context = context;
            _accounts = accounts;   
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staging>>> GetStaging()
        {
            return  _accounts.GetAccountService();
        }

        //public async Task<ActionResult<IEnumerable<Staging>>> GetStaging()
        //{
        //    if (_context.Staging == null)
        //    {
        //        return NotFound();
        //    }
        //    return await _context.Staging.ToListAsync();
        //}

        // GET: api/Accounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staging>> GetStaging(Guid id)
        {
          
            var staging = _accounts.GetAccountById(id);

            if (staging == null)
            {
                return NotFound();
            }

            return staging;
        }
        //public async Task<ActionResult<Staging>> GetStaging(Guid id)
        //{
        //  if (_context.Staging == null)
        //  {
        //      return NotFound();
        //  }
        //    var staging = await _context.Staging.FindAsync(id);

        //    if (staging == null)
        //    {
        //        return NotFound();
        //    }

        //    return staging;
        //}

        // PUT: api/Accounts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStaging(Guid id, Staging staging)
        //{
        //    if (id != staging.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(staging).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StagingExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Accounts
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Staging>> PostStaging(Staging staging)
        //{
        //  if (_context.Staging == null)
        //  {
        //      return Problem("Entity set 'StagingDbContext.Staging'  is null.");
        //  }
        //    _context.Staging.Add(staging);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetStaging", new { id = staging.Id }, staging);
        //}

        //// DELETE: api/Accounts/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStaging(Guid id)
        //{
        //    if (_context.Staging == null)
        //    {
        //        return NotFound();
        //    }
        //    var staging = await _context.Staging.FindAsync(id);
        //    if (staging == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Staging.Remove(staging);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool StagingExists(Guid id)
        //{
        //    return (_context.Staging?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}

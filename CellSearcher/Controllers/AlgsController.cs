using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CellSearcher.Models;

//on master branch.  Not saving.
// on master branch.  Will save, but not commit.
// I am writing this on the master branch.  I will save it.  I don't see how this could possible affect other branches.
// this is the master branch
//URL 52750
namespace CellSearcher.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AlgsController : ControllerBase
    {
        private readonly Alg927DbContext _context;

        public AlgsController(Alg927DbContext context)
        {
            _context = context; 
        }

        // GET: api/Algs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alg>>> GetAlgs()
        {
            return await _context.Algs.ToListAsync();
        }

        // GET: api/Algs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alg>> GetAlg(int id)
        {
            var alg = await _context.Algs.FindAsync(id);

            if (alg == null)
            {
                return NotFound();
            }

            return alg;
        }

        // PUT: api/Algs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlg(int id, Alg alg)
        {
            if (id != alg.Id)
            {
                return BadRequest();
            }

            _context.Entry(alg).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlgExists(id))
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

        // POST: api/Algs
        [HttpPost]
        public async Task<ActionResult<Alg>> PostAlg(Alg alg)
        {
            _context.Algs.Add(alg);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlg", new { id = alg.Id }, alg);
        }

        // DELETE: api/Algs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Alg>> DeleteAlg(int id)
        {
            var alg = await _context.Algs.FindAsync(id);
            if (alg == null)
            {
                return NotFound();
            }

            _context.Algs.Remove(alg);
            await _context.SaveChangesAsync();

            return alg;
        }

        private bool AlgExists(int id)
        {
            return _context.Algs.Any(e => e.Id == id);
        }
    }
}

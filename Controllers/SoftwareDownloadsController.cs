using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareDownloadSystem.Models;

namespace SoftwareDownloadSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftwareDownloadsController : ControllerBase
    {
        private readonly SDS_DBContext _context;

        public SoftwareDownloadsController(SDS_DBContext context)
        {
            _context = context;
        }

        // GET: api/SoftwareDownloads
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SoftwareDownload>>> GetsoftwareDownloads()
        {
            return await _context.softwareDownloadsystem.ToListAsync();
        }

        // GET: api/SoftwareDownloads/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SoftwareDownload>> GetSoftwareDownload(string id)
        {
            var softwareDownload = await _context.softwareDownloadsystem.FindAsync(id);

            if (softwareDownload == null)
            {
                return NotFound();
            }

            return softwareDownload;
        }

        // PUT: api/SoftwareDownloads/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftwareDownload(string id, SoftwareDownload softwareDownload)
        {
            softwareDownload.ID = id;
            _context.Entry(softwareDownload).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SoftwareDownloadExists(id))
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

        // POST: api/SoftwareDownloads
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SoftwareDownload>> PostSoftwareDownload(SoftwareDownload softwareDownload)
        {
            _context.softwareDownloadsystem.Add(softwareDownload);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SoftwareDownloadExists(softwareDownload.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSoftwareDownload", new { id = softwareDownload.ID }, softwareDownload);
        }

        // DELETE: api/SoftwareDownloads/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SoftwareDownload>> DeleteSoftwareDownload(string id)
        {
            var softwareDownload = await _context.softwareDownloadsystem.FindAsync(id);
            if (softwareDownload == null)
            {
                return NotFound();
            }

            _context.softwareDownloadsystem.Remove(softwareDownload);
            await _context.SaveChangesAsync();

            return softwareDownload;
        }

        private bool SoftwareDownloadExists(string id)
        {
            return _context.softwareDownloadsystem.Any(e => e.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web_API.Models;

namespace Web_API.Controllers
{
    public class NoticesController : Controller
    {
        private readonly HRMContext _context;

        public NoticesController(HRMContext context)
        {
            _context = context;
        }

        // GET: Notices
        [HttpGet]
        [Route("Notice")]
        public IActionResult Notice()
        {

            
            
                return Ok("Failure");
            


        }

        // GET: Notices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice
                .Include(n => n.PutP)
                .FirstOrDefaultAsync(m => m.NoId == id);
            if (notice == null)
            {
                return NotFound();
            }

            return View(notice);
        }

        // GET: Notices/Create
        public IActionResult Create()
        {
            ViewData["PutPId"] = new SelectList(_context.Position, "PId", "PId");
            return View();
        }

        // POST: Notices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NoId,DId,PId,EmpId,ToDate,From,NTitel,NBody,NPutId,NFromAll,PutPId,NLUpdateDate")] Notice notice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PutPId"] = new SelectList(_context.Position, "PId", "PId", notice.PutPId);
            return View(notice);
        }

        // GET: Notices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice.FindAsync(id);
            if (notice == null)
            {
                return NotFound();
            }
            ViewData["PutPId"] = new SelectList(_context.Position, "PId", "PId", notice.PutPId);
            return View(notice);
        }

        // POST: Notices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NoId,DId,PId,EmpId,ToDate,From,NTitel,NBody,NPutId,NFromAll,PutPId,NLUpdateDate")] Notice notice)
        {
            if (id != notice.NoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticeExists(notice.NoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PutPId"] = new SelectList(_context.Position, "PId", "PId", notice.PutPId);
            return View(notice);
        }

        // GET: Notices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notice = await _context.Notice
                .Include(n => n.PutP)
                .FirstOrDefaultAsync(m => m.NoId == id);
            if (notice == null)
            {
                return NotFound();
            }

            return View(notice);
        }

        // POST: Notices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notice = await _context.Notice.FindAsync(id);
            _context.Notice.Remove(notice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticeExists(int id)
        {
            return _context.Notice.Any(e => e.NoId == id);
        }
    }
}

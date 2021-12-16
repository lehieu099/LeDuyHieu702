using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeDuyHieu702.Models;
using MvcMovie.Data;

namespace LeDuyHieu702.Controllers
{
    public class UniversityLDH702Controller : Controller
    {
        private readonly LeDuyHieu702Context _context;

        public UniversityLDH702Controller(LeDuyHieu702Context context)
        {
            _context = context;
        }

        // GET: UniversityLDH702
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityLDH702.ToListAsync());
        }

        // GET: UniversityLDH702/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLDH702 = await _context.UniversityLDH702
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityLDH702 == null)
            {
                return NotFound();
            }

            return View(universityLDH702);
        }

        // GET: UniversityLDH702/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityLDH702/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityLDH702 universityLDH702)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityLDH702);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityLDH702);
        }

        // GET: UniversityLDH702/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLDH702 = await _context.UniversityLDH702.FindAsync(id);
            if (universityLDH702 == null)
            {
                return NotFound();
            }
            return View(universityLDH702);
        }

        // POST: UniversityLDH702/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UniversityId,UniversityName")] UniversityLDH702 universityLDH702)
        {
            if (id != universityLDH702.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityLDH702);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityLDH702Exists(universityLDH702.UniversityId))
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
            return View(universityLDH702);
        }

        // GET: UniversityLDH702/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityLDH702 = await _context.UniversityLDH702
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityLDH702 == null)
            {
                return NotFound();
            }

            return View(universityLDH702);
        }

        // POST: UniversityLDH702/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var universityLDH702 = await _context.UniversityLDH702.FindAsync(id);
            _context.UniversityLDH702.Remove(universityLDH702);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityLDH702Exists(string id)
        {
            return _context.UniversityLDH702.Any(e => e.UniversityId == id);
        }
    }
}
